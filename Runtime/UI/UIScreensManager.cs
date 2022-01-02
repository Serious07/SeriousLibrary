using SeriousLib.Singleton;
using System.Collections.Generic;
using UnityEngine;

namespace SeriousLib.UI
{
    [CreateAssetMenu(fileName = "UIScreensManager", menuName = "Singletons/UIScreensManager", order = 0)]
    public class UIScreensManager : SingletonMono<UIScreensManager>
    {
        public List<UIScreen> screens = new List<UIScreen>();

        public bool showWarnings = false;

        public void HideAllScreens()
        {
            foreach (IUIScreen screenInCollection in screens) {
                screenInCollection.HideScreen();
            }
        }
    }

    public class ScreensHelper<T> : System.Object where T : UIScreen
    {
        public static IUIScreen GetScreen()
        {
            return MonoBehaviour.FindObjectOfType<T>();
        }

        public static void Show(bool needToHideOther = true)
        {
            bool hasScreen = false;

            foreach (IUIScreen screenInCollection in UIScreensManager.instance.screens) {
                if (screenInCollection is T) {
                    if (needToHideOther) {
                        UIScreensManager.instance.HideAllScreens();
                    }

                    screenInCollection.ShowScreen();
                    hasScreen = true;
                    break;
                }
            }

            if (hasScreen == false) {
                Debug.LogError("Screen UI of type " + typeof(T) + " don't exists in UISingletonScreensManager for showing in game!");
            }
        }

        public static void Hide()
        {
            bool hasScreen = false;

            foreach (IUIScreen screenInCollection in UIScreensManager.instance.screens) {
                if (screenInCollection is T) {
                    screenInCollection.HideScreen();
                    hasScreen = true;
                    break;
                }
            }

            if (hasScreen == false) {
                Debug.LogError("Screen UI of type " + typeof(T) + " don't exists in UISingletonScreensManager for hide!");
            }
        }
    }
}
