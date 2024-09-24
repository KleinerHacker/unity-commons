using System;
using UnityBase.Runtime.Projects.unity_base.Scripts.Runtime.Utils.Extensions;
using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Assets;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Components
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    [AddComponentMenu("Audio/Audio Group Source")]
    public sealed class AudioGroupSource : MonoBehaviour
    {
        #region Inspector Data

        [SerializeField] private AudioClipGroup clipGroup;

        [Space] [SerializeField] private bool autoPlayOnStart = false;

        #endregion

        private AudioSource audioSource;

        #region Builtin Methods

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            if (autoPlayOnStart)
            {
                audioSource.clip = clipGroup.Clips.GetRandom();
                audioSource.Play();
            }
        }

        #endregion

        public void Play()
        {
            audioSource.Stop();
            audioSource.clip = clipGroup.Clips.GetRandom();
            audioSource.Play();
        }

        public void Play(ulong delay)
        {
            audioSource.Stop();
            audioSource.clip = clipGroup.Clips.GetRandom();
            audioSource.Play(delay);
        }

        public void PlayOneShot(AudioClipGroup clipGroup) => audioSource.PlayOneShot(clipGroup.Clips.GetRandom());
        
        public void PlayOneShot(AudioClipGroup clipGroup, float volumeScale) => audioSource.PlayOneShot(clipGroup.Clips.GetRandom(), volumeScale);

        public void Stop() => audioSource.Stop();

        public void Pause() => audioSource.Pause();

        public void UnPause() => audioSource.UnPause();
    }
}