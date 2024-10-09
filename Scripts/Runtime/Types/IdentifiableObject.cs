using System;
using UnityEditorEx.Runtime.Projects.unity_editor_ex.Scripts.Runtime.Extra;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Types
{
    [Serializable]
    public abstract class IdentifiableObject
    {
        #region Inspector Data

        [SerializeField]
        [ReadOnly]
        private string guid;

        #endregion

        #region Properties

        public string Guid
        {
            get => guid;
#if UNITY_EDITOR
            set => guid = value;
#endif
        }

        #endregion
    }
}