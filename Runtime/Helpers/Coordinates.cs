using UnityEngine;
using UnityEngine.EventSystems;

namespace SeriousLib.Coordinates
{
    public class Coordinates : MonoBehaviour
    {
        /// <summary>
        /// Get world coordinates based on screen coordinates
        /// </summary>
        /// <param name="cam">Camera to get position</param>
        /// <param name="screenPosition">Screen position</param>
        /// <returns>World position</returns>
        public static Vector3 GetWorldPosition(Camera cam, Vector3 screenPosition)
        {
            Vector3 worldPosition = cam.ScreenToWorldPoint(screenPosition);
            worldPosition.z = 0;
            return worldPosition;
        }

        /// <summary>
        /// Get world coordinates based on screen coordinates
        /// </summary>
        /// <param name="screenPosition">Screen position</param>
        /// <returns>World position</returns>
        public static Vector3 GetWorldPosition(Vector3 screenPosition)
        {
            return GetWorldPosition(Camera.main, screenPosition);
        }

        /// <summary>
        /// Is mouse pointer over Unity UI Object
        /// </summary>
        /// <returns>Returns true if pointer on UI Object, false if pointer not on UI Object</returns>
        public static bool isPointerOverUI()
        {
            return EventSystem.current.IsPointerOverGameObject();
        }
    }
}