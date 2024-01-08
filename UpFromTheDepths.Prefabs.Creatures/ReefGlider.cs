using System;
using ECCLibrary;
using ECCLibrary.Data;
using Nautilus.Assets;
using UnityEngine;


namespace UpFromTheDepths.Prefabs.Creatures
{
	internal class ReefGlider : CreatureAsset
	{
		public ReefGlider(PrefabInfo prefabInfo) : base(prefabInfo)
		{
		}

		protected override CreatureTemplate CreateTemplate()
		{
			CreatureTemplate creatureTemplate = new CreatureTemplate(Plugin.AssetBundle.LoadAsset<GameObject>("ReefGlider"), BehaviourType.Leviathan, EcoTargetType.Leviathan, 1000f)
			{
				BehaviourLODData = new BehaviourLODData(200f, 1000f, 5000f),
				CellLevel = LargeWorldEntity.CellLevel.Far,
				SwimRandomData = new SwimRandomData(0.2f, 10f, new Vector3(30f, 10f, 30f), 4f, 1f, true),
				StayAtLeashData = new StayAtLeashData(0.6f, 10f, 60f, 1f, 3f),
				AvoidTerrainData = new AvoidTerrainData(0.7f, 10f, 30f, 30f, 0.5f, 10f),
				AcidImmune = true,
				BioReactorCharge = 4000f,
				Mass = 2000f,
				EyeFOV = -0.75f,
				AnimateByVelocityData = new AnimateByVelocityData(15f, 30f, 45f, false, 0.5f),
				AttackLastTargetData = new AttackLastTargetData(0.8f, 12f, 0.5f, 10f, 20f, 3f, 5f, true),
				AttackCyclopsData = new AttackCyclopsData(1f, 15f, 100f, 0.4f, 3f, 0.01f, 0.75f)
			};
			creatureTemplate.BehaviourLODData = new BehaviourLODData(50f, 250f, 500f);
			return creatureTemplate;
		}
	}
}