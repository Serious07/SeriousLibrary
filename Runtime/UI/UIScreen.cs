using System;
using UnityEngine;

namespace SeriousLib.UI
{
    public class UIScreen : MonoBehaviour, IUIScreen
    {
        private static Action<IUIScreen> _OnShow;
        private static Action<IUIScreen> _OnHide;
        [SerializeField]
        private GameObject _gameObject;
        private GameObject _gameObjectOnScene;

        public Action<IUIScreen> OnShow {
            get { return _OnShow; }
            set { _OnShow = value; }
        }
        public Action<IUIScreen> OnHide {
            get { return _OnHide; }
            set { _OnHide = value; }
        }
        [SerializeField]
        public GameObject go {
            get { return _gameObject; }
            set { _gameObject = value; }
        }

        public virtual void ShowScreen()
        {
            Canvas[] canvasGameObjects = FindObjectsOfType<Canvas>();
            Canvas gameMainCanvas = null;

            if (canvasGameObjects != null && canvasGameObjects.Length > 0) {
                foreach(Canvas canvas in canvasGameObjects) {
                    if(canvas.renderMode == RenderMode.ScreenSpaceOverlay || canvas.renderMode == RenderMode.ScreenSpaceCamera) {
                        gameMainCanvas = canvas;
                    }
                }
            } else if (canvasGameObjects != null && canvasGameObjects.Length == 0) {
                Debug.LogError("Scene don't contains Canvas for UI!");
                return;
            }

            if (gameMainCanvas != null) {
                _gameObjectOnScene = Instantiate(go, gameMainCanvas.transform);

                _gameObjectOnScene.SetActive(true);

                if (OnShow != null) OnShow.Invoke(this);
            }
        }

        public virtual void HideScreen()
        {
            GameObject canvasGameObject = FindObjectOfType<Canvas>().gameObject;

            if (canvasGameObject == null) {
                Debug.LogError("Scene don't contains Canvas for UI!");
                return;
            }

            if (_gameObjectOnScene != null) {
                Destroy(_gameObjectOnScene);
                _gameObjectOnScene = null;
            } else {
                if (UIScreensManager.instance.showWarnings) {
                    Debug.LogWarning("UI screen " + this.GetType().ToString() + " don't exists! Nothing to hide.");
                }
            }

            if (OnHide != null) OnHide.Invoke(this);
        }

        public virtual void Init()
        {
            gameObject.SetActive(false);
        }
    }
}
