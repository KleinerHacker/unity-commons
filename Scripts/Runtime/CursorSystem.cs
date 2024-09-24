#if PCSOFT_CURSOR
using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Components;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime
{
    public static class CursorSystem
    {
        public static bool IsVisible
        {
            get => CursorController.Singleton.IsVisible;
            set => CursorController.Singleton.IsVisible = value;
        }
        
        public static CursorLockMode LockMode
        {
            get => CursorController.Singleton.LockMode;
            set => CursorController.Singleton.LockMode = value;
        }

        public static void ChangeCursor(string key) => CursorController.Singleton.ChangeCursor(key);

        public static void ResetCursor() => CursorController.Singleton.ResetCursor();
    }
}
#endif