#if PCSOFT_CURSOR
using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Components;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime
{
    public static class CursorSystem
    {
        public static bool IsVisible
        {
            get => CursorController.Instance.IsVisible;
            set => CursorController.Instance.IsVisible = value;
        }
        
        public static CursorLockMode LockMode
        {
            get => CursorController.Instance.LockMode;
            set => CursorController.Instance.LockMode = value;
        }

        public static void ChangeCursor(string key) => CursorController.Instance.ChangeCursor(key);

        public static void ResetCursor() => CursorController.Instance.ResetCursor();
    }
}
#endif