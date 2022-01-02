using UnityEngine;
using System;
using SeriousLib.Singleton;

namespace SeriousLib.Input
{
    /// <summary>
    /// Singleton to read and react to mouse Inputs
    /// </summary>
    public class MouseInputReader : SingletonMono<MouseInputReader>
    {
        // On Mouse Button Down
        public static Action<Vector3> onMouseLeftButtonDown;
        public static Action<Vector3> onMouseRightButtonDown;

        // On Mouse Button Up
        public static Action<Vector3> onMouseLeftButtonUp;
        public static Action<Vector3> onMouseRightButtonUp;

        // On Mouse Button
        public static Action<Vector3> onMouseLeftButton;
        public static Action<Vector3> onMouseRightButton;

        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0)) {
                onMouseLeftButtonDown?.Invoke(UnityEngine.Input.mousePosition);
            }

            if (UnityEngine.Input.GetMouseButtonDown(1)) {
                onMouseRightButtonDown?.Invoke(UnityEngine.Input.mousePosition);
            }

            if (UnityEngine.Input.GetMouseButtonUp(0)) {
                onMouseLeftButtonUp?.Invoke(UnityEngine.Input.mousePosition);
            }

            if (UnityEngine.Input.GetMouseButtonUp(1)) {
                onMouseRightButtonUp?.Invoke(UnityEngine.Input.mousePosition);
            }

            if (UnityEngine.Input.GetMouseButton(0)) {
                onMouseLeftButton?.Invoke(UnityEngine.Input.mousePosition);
            }

            if (UnityEngine.Input.GetMouseButton(1)) {
                onMouseRightButton?.Invoke(UnityEngine.Input.mousePosition);
            }
        }
    }
}