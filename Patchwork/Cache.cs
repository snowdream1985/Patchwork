using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Patchwork;
using UnityEngine;
using System.IO.IsolatedStorage;

interface IDumpable
{
	bool Unmarshal(string v);
	string Marshal();
}

public class GenericMarshaller : ScriptableObject
{
	public bool Unmarshal(string v)
	{
		return false;
	}
	public string Marshal()
	{
		return null;
	}
}

public class Cache
{
	static string dumpdir => Application.dataPath + "/../mod/";
	public static bool LoadLst(string bundle, string asset, out string[,] data)
	{
		var tfolder = dumpdir + Path.ChangeExtension(bundle, null);
		var lstfile = tfolder + "/" + asset + ".lst";
		string text = null;
		data = null;


		if (Program.settings.fetchAssets)
		{
			try
			{
				text = System.Text.Encoding.UTF8.GetString(File.ReadAllBytes(lstfile));
			}
			catch { Trace.Back(); };
		}
		if (text == null)
		{
			var ta = CommonLib.LoadAsset<TextAsset>(bundle, asset);
			if (ta == null)
				return false;
			
			text = ta.text;
			if (Program.settings.dumpAssets)
			{
				try
				{
					try
					{
						Directory.CreateDirectory(tfolder);
					}
					catch { };

					File.WriteAllBytes(lstfile, System.Text.Encoding.UTF8.GetBytes(text));
				}
				catch { Trace.Back();  };
			}
		}


		YS_Assist.GetListString(text, out data);
		return true;
	}

	public static bool Asset(string bundle, string asset, System.Type type, string manifest, out AssetBundleLoadAssetOperation res)
	{
		res = null;
		if (Application.dataPath == null)
			return false;
		if (Program.settings == null)
			return false;
		if (asset == null)
			return false;

		var basedir = AssetBundleManager.BaseDownloadingURL;
		var tfolder = dumpdir + Path.ChangeExtension(bundle, null);

		if (!typeof(IDumpable).IsAssignableFrom(type))
			return false;
		if (!Program.settings.dumpAssets && !Program.settings.fetchAssets)
			return false;

		var csvfile = tfolder + "/" + asset + ".csv";

		if (Program.settings.fetchAssets)
		{
			try
			{
				var ex = ScriptableObject.CreateInstance(type) as IDumpable;
				if (!ex.Unmarshal(System.Text.Encoding.UTF8.GetString(File.ReadAllBytes(csvfile))))
					return false;
				res = new AssetBundleLoadAssetOperationSimulation((Object)ex);
			}
			catch (FileNotFoundException) { }
			catch (IsolatedStorageException) { }
			catch (System.Exception ex)
			{
				return false;
			};
		}

		if (res != null)
			return true;

		try
		{
			if (Program.settings.dumpAssets)
				Directory.CreateDirectory(tfolder);
		}
		catch { };

		res = AssetBundleManager._LoadAsset(bundle, asset, type, manifest);

		if (!res.IsEmpty() && Program.settings.dumpAssets)
		{
			var ex = res.GetAsset<Object>() as IDumpable;
			if (ex == null)
			{
				try
				{
					Debug.Log($"[CACHE] Mismatched type {type.Name} -> {res.GetAsset<Object>()}");
				}
				catch { };
				return true;
			}

			if (Program.settings.dumpAssets)
			{
				var buf = ex.Marshal();
				if (buf != null)
					File.WriteAllBytes(csvfile, System.Text.Encoding.UTF8.GetBytes(buf));
			}
		}

		return true;
	}

	public static HashSet<string> ncache = new HashSet<string>();
	public static Texture2D LoadGPU(string bundle, string asset, string manifest)
	{
		if (manifest.IsNullOrEmpty())
			manifest = "abdata";
		var path = manifest + "/" + bundle + "/" + asset;
		if (ncache.Contains(path))
			return null;
		Texture2D tex = null;
		try
		{
			tex = AssetBundleManager.LoadAsset(bundle, asset, typeof(Texture2D), manifest).GetAsset<Texture2D>();
		} catch (System.Exception ex)
		{
			Debug.Log("Texture load failed with: " + ex.ToString());
		}
		if (tex == null)
		{
			ncache.Add(path);
		}
		Debug.Log($"[TEXTURE] {manifest}/{path} {tex.GetInstanceID()}");
		return tex;
	}
}
