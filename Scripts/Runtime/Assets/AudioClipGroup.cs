using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Assets
{
    [CreateAssetMenu(menuName = "Audio/Audio Clip Group", fileName = "audio-clip-group")]
    public sealed class AudioClipGroup : ScriptableObject
    {
        #region Inspector Data

        [SerializeField]
        private AudioClip[] clips;

        #endregion

        #region Properties

        public AudioClip[] Clips => clips;

        #endregion
    }
}