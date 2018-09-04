using System;
using System.Reflection;
using Harmony;
using HugsLib;
using UnityEngine.SceneManagement;
using Verse;

namespace Politics
{
    public class Politics : ModBase
    {
        public override string ModIdentifier => "Politics";

        public override ModContentPack ModContentPack => base.ModContentPack;

        protected override bool HarmonyAutoPatch => base.HarmonyAutoPatch;

        static Politics()
        {
            var harmony = HarmonyInstance.Create("com.github.khaligufzel.rimworld.politics");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public override void DefsLoaded()
        {
            base.DefsLoaded();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override Version GetVersion()
        {
            return base.GetVersion();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void MapComponentsInitializing(Map map)
        {
            base.MapComponentsInitializing(map);
        }

        public override void MapDiscarded(Map map)
        {
            base.MapDiscarded(map);
        }

        public override void MapGenerated(Map map)
        {
            base.MapGenerated(map);
        }

        public override void MapLoaded(Map map)
        {
            base.MapLoaded(map);
        }

        public override void OnGUI()
        {
            base.OnGUI();
        }

        public override void SceneLoaded(Scene scene)
        {
            base.SceneLoaded(scene);
        }

        public override void SettingsChanged()
        {
            base.SettingsChanged();
        }

        public override void Tick(int currentTick)
        {
            base.Tick(currentTick);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void WorldLoaded()
        {
            base.WorldLoaded();
        }
    }
}