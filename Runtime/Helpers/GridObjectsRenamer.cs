using UnityEngine;

namespace SeriousLib.Inspector
{
    /// <summary>
    /// Components that allow you rename child objects if they alighned with 2D grid
    /// </summary>
    public class GridObjectsRenamer : MonoBehaviour
    {
        [SerializeField] private string prefixName;
        [SerializeField] private int width;
        [SerializeField] private int height;

        [ContextMenu("Rename")]
        private void RenameGridObjects()
        {
            int tmpX;
            int tmpY;

            for (int i = 0; i < transform.childCount; i++) {
                tmpX = (i % width) + 1;
                tmpY = (i / height) + 1;

                transform.GetChild(i).gameObject.name = prefixName + " col: " + tmpX + " row: " + tmpY;
            }
        }
    }
}