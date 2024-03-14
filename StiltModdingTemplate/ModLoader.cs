using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(StiltModdingTemplate.ModLoader), "modname", "1.0.0", "modauthor")]
[assembly: MelonGame("Rekt Games", "Stilt")]

//Change the namespace to whatever you want
namespace StiltModdingTemplate {
    public class ModLoader : MelonMod {
        public static ModLoader instance;
        public GameObject ModManager;

        public override void OnLateInitializeMelon() {
            base.OnLateInitializeMelon();
            instance = this;
            CreateManagerForObject();
        }

        void CreateManagerForObject() {
            //Name this whatever you want
            ModManager = new GameObject("ModManagerObject");

            //Put all the MonoBehaviour scripts you want to load here
            ModManager.AddComponent<Main>();

            GameObject.DontDestroyOnLoad(ModManager);
        }
    }
}