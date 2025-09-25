using UnityAssetLoader.Runtime.Projects.unity_asset_loader.Scripts.Runtime;
using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Assets;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime
{
    public static class UnityCommonsStartupEvents
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize()
        {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
            Debug.Log("Load debug...");
            AssetResourcesManager.FromResources<DebugSettings>("").Load();
#endif

#if PCSOFT_CURSOR
            Debug.Log("Load cursor system...");
            AssetResourcesManager.FromResources<CursorSettings>("").Load();
#endif
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void LateInitialize()
        {
        }
    }
}