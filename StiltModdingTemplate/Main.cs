using MelonLoader;
using StiltModdingAPI.Behaviours.Events;
using UnityEngine;

//Change the namespace to whatever you want
namespace StiltModdingTemplate {
    //This class is just like a normal unity script, everything is already set up for you so this class will get loaded after the api gets loaded.
    public class Main : MonoBehaviour {
        //Gets called when the script loads
        void Awake() {
            StiltEventHandler.instance.OnSceneLoaded += OnStiltSceneLoaded;
        }
        
        //This will run when a new scene in stilt loads, use this instead of the unity changed scene event.
        void OnStiltSceneLoaded(bool ContainsPlayerPrefab, bool IsMultiplayerScene) {
            MelonLogger.Msg("scene");
            if (ContainsPlayerPrefab) {
                MelonLogger.Msg("player prefab scene");
                //Run code here if you want your mod to only do stuff if the rig is in the scene
            }

            if(IsMultiplayerScene) {
                MelonLogger.Msg("multiplayer scene");
                //Run code here if you want your mod to only do stuff if the scene is a multiplayer scene
            }
        }

        //Gets called every frame the mod is active
        void Update() {

        }
    }
}