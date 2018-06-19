﻿//@INFO: Compatibility for Id colliding mods
//@DESC: Rewrite item ids to fake ones so that broken mods still show up

using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Patchwork;
using System.Linq;
using System.Collections.Generic;
using MessagePack;
using static ChaListDefine;

public class FakeID : MonoBehaviour
{
	public void Start()
	{
		InitListInfo();
	}

	// ids to never rewrite as the game code treats em specially
	public static HashSet<KeyValuePair<int,int>> exempt = new HashSet<KeyValuePair<int, int>>()
	{
		new KeyValuePair<int, int>((int)CategoryNo.co_top, 1),
		new KeyValuePair<int, int>((int)CategoryNo.co_top, 2),
	};

	// (re)load the listinfos
	public static IdMap idMap;
	public void InitListInfo()
	{
		idMap = Script.registry<IdMap>("fixplugins.idMap");
		if (Manager.Character.Instance != null)
		{
			Manager.Character.Instance.chaListCtrl = new ChaListControl();
			Manager.Character.Instance.chaListCtrl.LoadListInfoAll();
		}
	}

	public static ChaListControl ctrl => Manager.Character.Instance.chaListCtrl;

	// When a new item list entry is created, remap its id to fake index
	// to ensure its unique. At the same time, remember the mapping so that
	// we can rewrite the ids in card data back and forth on load/save later on.
	public void OnSetListInfo(ListInfoBase lib)
	{
		lib.Id = idMap.NewFake(lib.Category, lib.Id, lib.Clone());
	}

	public class IdMap
	{
		public int counter = -3;
		// map a real <cat,id> pair to list of fake ids
		public Dictionary<KeyValuePair<int, int>, List<int>> real2fake = new Dictionary<KeyValuePair<int, int>, List<int>>();
		// map one fake id to real <cat,id,dist> (all contained in infobase)
		public Dictionary<int, ListInfoBase> fake2real = new Dictionary<int, ListInfoBase>();
		public int NewFake(int cat, int realid, ListInfoBase data)
		{
			var realpair = new KeyValuePair<int, int>(cat, realid);
			List<int> fakeids;
			if (!real2fake.TryGetValue(realpair, out fakeids))
				fakeids = real2fake[realpair] = new List<int>();
			// already added?
			foreach (var item in fakeids)
				if (fake2real[item].Distribution2 == data.Distribution2)
					return item;
			// otherwise make a new fake
			int fakeid = exempt.Contains(realpair) ? realid : --counter;
			fakeids.Add(fakeid);
			fake2real[fakeid] = data;
			return fakeid;
		}
	}

	[MessagePackObject(true)]
	public class GuidMap
	{
		[MessagePackObject(true)]
		public class Item
		{
			public string guid;
			public int cat;
			public int id;
			public string prop;
		}
		public Dictionary<string, Item> items = new Dictionary<string, Item>();

		// translate real to fake, taking into account guid hints.
		// if no hint is present, first fake is used
		public int GetFake(string prop, int cat, int id)
		{
			Item item;
			List<int> candidates;
			var realpair = new KeyValuePair<int, int>(cat, id);
			if (items.TryGetValue(prop, out item))
			{
				if (idMap.real2fake.TryGetValue(realpair, out candidates))
				{
					var match = candidates.FirstOrDefault((x) => idMap.fake2real[x].Distribution2 == item.guid);
					if (match != 0)
						return match;
				}
			}
			// nothing found via our guid mappings, so default to a first fake we encounter
			if (idMap.real2fake.TryGetValue(realpair, out candidates))
				return candidates.FirstOrDefault();

			print($"can't find {prop}/{cat}/{id}");

			return int.MaxValue;
		}

		// translate fake id to a real one. at the same time, record guid usage.
		public int GetReal(string prop, int cat, int id)
		{
			ListInfoBase lib = idMap.fake2real[id];
			if (lib.Distribution2 == "") // if no guid now, nuke the mapping
				items.Remove(prop);
			else
				items[prop] = new Item() {
					guid = lib.Distribution2,
					cat = cat,
					id = lib.Id,
					prop = prop
				};
			return lib.Id;
		}
	}

	public GuidMap map;
	public bool tofake;

	public int rewrite(string prefix, int cat, int id, string name)
	{
		int newid = id;
		if (cat < 0)
			return id;
		if (tofake)
		{
			newid = map.GetFake(prefix, cat, id);
			int id2 = -1;
			try
			{
				id2 = map.GetReal(prefix, cat, newid);
			} catch (Exception ex)
			{
				print(ex);
			}
			if (id != id2)
				print($"Rewrite failed {prefix} {cat}: {id} => {newid} => {id2}");
		} else
		{
			newid = map.GetReal(prefix, cat, id);
		}
		return newid;
	}

	public int currIdx;

	// traverse object and rewrite ids
	public void traverse(string prefix, object root)
	{
		if (root == null) return;
		var t = root.GetType();

		if (t.IsArray)
		{
			var arr = root as Array;
			int idx = 0;
			if (arr != null)
				foreach (var sub in arr)
				{
					if (!sub.GetType().IsBasic())
						traverse($"{prefix}[{currIdx = idx++}]", sub);
				}
			currIdx = 0;
			return;
		}

		foreach (var mem in t.GetVars())
		{
			var name = mem.Name;
			var mt = mem.GetVarType();
			if (mt == null) continue;

			if (name == "pattern" || name == "id" || name.EndsWith("Id"))
			{
				CatHint hint = null;
				if (!mem.GetAttr(ref hint))
				{
					print($"Missing hint for {prefix}.{name}");
					continue;
				}

				if (hint.hint == (int)CategoryNo.dynamic)
					hint.hint = (int)t.GetMethod(name + "_cat").Invoke(root, new object[] { currIdx });
				var val = mem.GetValue(root);
				var arr = val as Array;
				if (mt == typeof(int))
					mem.SetValue(root, rewrite(prefix + "." + name, hint.hint, (int)val, name));
				else if (arr != null && mt.GetElementType() == typeof(int))
				{
					for (int i = 0; i < arr.Length; i++)
					{
						arr.SetValue(rewrite($"{prefix}.{mem.Name}[{i}]", hint.hint, (int)arr.GetValue(i), name), i);
						hint.Next();
					}
				}
			}
			else if (mt.IsArray || t.GetMethod("SaveBytes") != null || t.HasAttr<MessagePackObjectAttribute>())
				traverse(prefix + "." + name, mem.GetValue(root));

		}
	}

	// id rewriter should run last, after guid preference tables are populated
	public void OnCardLoad_1000(ChaFile f, BlockHeader bh, bool nopng, bool nostatus)
	{
		map = f.dict.Get<GuidMap>("guidmap");
		tofake = true;
		print("Traverse?");
		traverse("coordinate",f.coordinate);
		traverse("custom",f.custom);
	}

	// rewrite our fake ids to the actual real ones again
	public void OnCardSave(ChaFile f, BinaryWriter w, List<object> blocks, bool nopng)
	{
		map = f.dict.Get<GuidMap>("guidmap");
		map.items.Clear(); // guid mappings will be be-regenerated
		tofake = false;
		foreach (var b in blocks)
		{
			if ((b is Array) && b.GetType().GetElementType() == typeof(ChaFileCoordinate))
				traverse("coordinate", b);
			else if (b is ChaFileCustom)
				traverse("custom", b);
		}
	}
}
