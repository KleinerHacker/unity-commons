using UnityBase.Runtime.Projects.unity_base.Scripts.Runtime.Components.Singleton;
using UnityBase.Runtime.Projects.unity_base.Scripts.Runtime.Components.Singleton.Attributes;
using UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Assets;
using UnityEngine;

namespace UnityCommons.Runtime.Projects.unity_commons.Scripts.Runtime.Components.UDebug
{
#if UNITY_EDITOR || DEVELOPMENT_BUILD
    [Singleton(ObjectName = "Debug Framerate")]
    public sealed class DebugFramerate : SingletonBehavior<DebugFramerate>
    {
        private GUIStyle _style;
        private float _deltaTime;
        private byte _counter;
        private string _text = "";

        #region Builtin Methods

        private void Awake()
        {
            _style = new GUIStyle
            {
                alignment = DebugSettings.Singleton.FrameratePosition,
                fontSize = DebugSettings.Singleton.FramerateTextSize,
                normal =
                {
                    textColor = DebugSettings.Singleton.FramerateColor
                }
            };
        }

        private void Update()
        {
            _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * 0.1f;
        }

        private void FixedUpdate()
        {
            _counter++;
            if (_counter >= DebugSettings.Singleton.FramerateUpdateRate)
            {
                _counter = 0;

                var msec = _deltaTime * 1000.0f;
                var fps = 1.0f / _deltaTime;
                _text = $"{msec:0.0} ms ({fps:0.} fps)";
            }
        }

        private void OnGUI()
        {
            GUI.Label(Screen.safeArea, _text, _style);
        }

        #endregion

        protected override void OnInitializeSingleton()
        {
            enabled = DebugSettings.Singleton.ShowFramerate;
        }
    }
#endif
}