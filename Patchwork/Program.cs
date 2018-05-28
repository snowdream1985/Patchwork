using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;
using System.Threading;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Diagnostics;
using MessagePack;
using System.Text;
using System.Configuration;
using System.Xml.Serialization;
using System.Drawing;

namespace Patchwork
{
	public static partial class Program
	{
		public static int version
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.Major;
			}
		}

		public static bool isStudio
		{
			get
			{
				return UnityEngine.Application.productName == "CharaStudio";
			}
		}
		public static string prefix { get {
				return isStudio ? "Studio" : "";
			}
		}

		public static string BasePath;

		// Don't touch unity in weird places if local
		public static string cfgpath { get { return BasePath + "UserData/patchwork.xml"; } }
		public static SettingsForm form;
		public static Settings _settings;
		public static Settings settings
		{
			get
			{
				if (_settings == null)
					_settings = LoadConfig();
				return _settings;
			}
		}
		public static fsSerializer _fsjson;
		public static fsSerializer fsjson {
			get {
				if (_fsjson == null)
				{
					_fsjson = new fsSerializer();
				}
				return _fsjson;
			}
		}

		public static bool launched = false;
		public static bool earlydone = false;

		public static void ConfigDialog()
		{
			//System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(true);
			if (settings.dontshow || (Environment.GetEnvironmentVariable("KK_RUNSTUDIO") != null))
			{
				launched = true;
				return;
			}
			form = new SettingsForm(settings);
			form.Text += " Mk." + Assembly.GetExecutingAssembly().GetName().Version.Major;
			form.resolution.Items.AddRange(settings.resolutions);
			foreach (var n in settings.chardbs)
				form.chardb.Items.Add(n.Split('|')[0]);
			form.UpdateForm();
			form.launchButton.Click += (o, e) =>
			{
				launched = true;
				form.Close();
			};
			form.runChara.Click += (o, e) =>
			{
				form.Close();
				Environment.SetEnvironmentVariable("KK_RUNSTUDIO", "1");
				Process.Start(exename);
				Environment.Exit(0);
			};
			if (form.ShowDialog() == DialogResult.OK)
				launched = true;
			SaveConfig();
			if (!launched)
				Environment.Exit(1);
			form.launchButton.Enabled = false;
			form.runChara.Enabled = false;
			form.Show();
		}
		public static string exename;

		public static int Main(string[] args)
		{
			var fn = new StringBuilder(256);
			GetModuleFileName(IntPtr.Zero, fn, fn.Capacity);
			exename = fn.ToString();
			BasePath = Path.GetDirectoryName(exename) + "/";
			LoadConfig();
			Trace.Info("Basepath=" + BasePath);
			ConfigDialog();
			earlydone = true;
			return 0;
		}

		public static void FixWindow()
		{
			if (settings.resizable && !UnityEngine.Screen.fullScreen)
			{
				var ow = GetWindowLongPtr(hwnd, -16);
				SetWindowLongPtr(hwnd, -16, ow | 0x00040000L | 0x00010000L);
			}
		}

		public static Settings LoadConfig()
		{
			Settings s = null;
			XmlSerializer x = new XmlSerializer(typeof(Settings));
			try
			{
				using (var f = File.Open(cfgpath, FileMode.Open))
					s = x.Deserialize(f) as Settings;
			}
			catch { };
			return s ?? new Settings();
		}

		public static void SaveConfig()
		{
			try
			{
				XmlSerializer x = new XmlSerializer(typeof(Settings));
				using (var f = File.Open(cfgpath, FileMode.Create))
					x.Serialize(f, settings);
			}
			catch (Exception ex) {
				Trace.Error("Saving config failed with " + ex.ToString());
			};
		}

		public static IntPtr hwnd = (IntPtr)(-1);

		public static bool initdone = false;
		public static void AssertLate(string by="")
		{
			if (!earlydone)
			{
				var msg = "AssertLate failed from: " + by + "\n" + Environment.StackTrace;
				Console.WriteLine(msg);
				Console.Out.Flush();
				MessageBox.Show(msg, "Fatal error", MessageBoxButtons.OK);
				Environment.FailFast(msg);
			}
		}

		public static void PostInit()
		{
			initdone = true;
			settings.Apply(true);
			SaveConfig();

			AppDomain.CurrentDomain.AssemblyResolve += (s, args) =>
			{
				var shortname = new System.Reflection.AssemblyName(args.Name).Name;
				Debug.Log("something is looking for " + shortname);
				var loadedAssembly = System.AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().Name == shortname).FirstOrDefault();
				if (loadedAssembly != null)
				{
					return loadedAssembly;
				}
				return null;
			};

			// Fire up scripts
			Script.Init();

			// Fix up window
			var proc = Process.GetCurrentProcess();
			EnumThreadWindows(GetCurrentThreadId(), (W, _) => {
				var sb = new System.Text.StringBuilder(256);
				GetClassName(W, sb, 256);
				if (sb.ToString() == "UnityWndClass")
					hwnd = W;
				return true;
			}, IntPtr.Zero);
			SetWindowText(hwnd, UnityEngine.Application.productName + " Mk." + version);

		}

		public static void UpdateCamera()
		{
			settings.Apply("renderingPath");
			// perhaps apply other overrides as they come up
		}

		public static void GC(string who, bool wants, object o)
		{
			Trace.Spam("[GC]" + who);
			if (!settings.lazyGC && wants)
			{
				Resources.UnloadUnusedAssets();
			}
			if (settings.lazyBundles)
				AssetBundleManager.GC();
			System.GC.Collect();
		}

		public static void GCAssets(object caller)
		{
			Trace.Spam($"[GC] Asset GC requested by {caller.GetType().Name}");
		}

	}
}
