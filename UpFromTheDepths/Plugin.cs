using System;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using Nautilus.Assets;
using Nautilus.Utility;
using HarmonyLib;
using UpFromTheDepths.Prefabs.Creatures;
using UnityEngine;


namespace UpFromTheDepths
{
	[BepInPlugin("com.thiccymouse.upfromthedepths", "Up from the Depths", Nautilus.PluginInfo.PLUGIN_VERSION)]
	[BepInDependency("com.snmodding.nautilus")]
	public class Plugin : BaseUnityPlugin
	{
		public static ManualLogSource Logger { get; private set; }
		public static AssetBundle AssetBundle { get; private set; }
		private static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();

		private void Awake()
		{
			Plugin.Logger = base.Logger;
			Plugin.AssetBundle = AssetBundleLoadingUtils.LoadFromAssetsFolder(Plugin.Assembly, "up_from_the_depths_assets");
			this.InitializePrefabs();
			Harmony.CreateAndPatchAll(Plugin.Assembly, "com.thiccymouse.upfromthedepths");
			Plugin.Logger.LogInfo("Plugin com.thiccymouse.upfromthedepths is loaded!");
		}

		private void InitializePrefabs()
		{
            ReefGlider reefGlider = new ReefGlider(PrefabInfo.WithTechType("ReefGlider", false, null));
			reefGlider.Register();
		}
	}
}
