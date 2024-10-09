using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Components.UDebug.GizmosNote;
using UnityEditor;
using UnityEngine;

namespace UnityCommons.Editor.Projects.unity_commons.Scripts.Editor.Components.UDebug.GizmosNote.Editor
{
    public static class GizmosNoteAction
    {
        [MenuItem("GameObject/Debug/Gizmos Area Note", priority = -10000)]
        public static void CreateGizmosAreaNote()
        {
            var go = new GameObject("Gizmos Area Note");
            go.AddComponent<GizmosAreaNote>();
        }
    }
}