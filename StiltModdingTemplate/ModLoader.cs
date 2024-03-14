using MelonLoader;
using StiltModdingAPI;
using StiltModdingAPI.Behaviours.Events;

[assembly: MelonInfo(typeof(StiltModdingTemplate.ModLoader), "modname", "1.0.0", "modauthor")]
[assembly: MelonGame("Rekt Games", "Stilt")]

//Change the namespace to whatever you want
namespace StiltModdingTemplate {
    public class ModLoader : MelonMod {
        public override void OnLateInitializeMelon() {
            base.OnLateInitializeMelon();
            StiltEventHandler.instance.OnAPILoaded += StiltAPILoaded;
        }

        //This method runs when the StiltModdingAPI successfully loads
        void StiltAPILoaded() {
            bool SuccessfullyLoadedScript = Utils.RegisterStiltScript<Main>();
            //The bool turns true if the script successfully loads and false if not.
        }
    }
}