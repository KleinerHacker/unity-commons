using UnityEditor;
using UnityEngine;

namespace UnityCommons.Editor.Projects.unity_commons.Scripts.Editor.Actions
{
    public static class AssetActions
    {
        [MenuItem("Assets/Copy GUID", priority = int.MaxValue)]
        public static void CopyGUID() 
        {
            var assetPath = AssetDatabase.GetAssetPath(Selection.activeObject.GetInstanceID());
            var guid = AssetDatabase.GUIDFromAssetPath(assetPath);

            GUIUtility.systemCopyBuffer = guid.ToString();
        }
    }
}