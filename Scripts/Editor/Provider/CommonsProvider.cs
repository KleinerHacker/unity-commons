using System.Collections.Generic;
using UnityEditor;
using UnityEditorEx.Editor.Projects.unity_editor_ex.Scripts.Editor.Utils;
using UnityEngine;

namespace UnityCommons.Editor.Projects.unity_commons.Scripts.Editor.Provider
{
    public sealed class CommonsProvider : SettingsProvider
    {
        #region Static Area

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new CommonsProvider();
        }

        #endregion

        public CommonsProvider() : base("Project/Player/Commons", SettingsScope.Project, new List<string>() { "Commons", "Singleton" })
        {
        }

        public override void OnGUI(string searchContext)
        {
            var isSingletonLogging = PlayerSettingsEx.IsScriptingSymbolDefined(UnityCommonsEditorConstants.Building.Symbol.SingletonLogging);
            var newSingletonLogging = GUILayout.Toggle(isSingletonLogging, "Verbose Singleton Logging");
            if (isSingletonLogging != newSingletonLogging)
            {
                if (newSingletonLogging)
                {
                    PlayerSettingsEx.AddScriptingSymbol(UnityCommonsEditorConstants.Building.Symbol.SingletonLogging);
                }
                else
                {
                    PlayerSettingsEx.RemoveScriptingSymbol(UnityCommonsEditorConstants.Building.Symbol.SingletonLogging);
                }
            }
        }
    }
}