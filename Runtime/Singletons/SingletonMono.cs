using UnityEngine;

namespace SeriousLib.Singleton
{
    /// <summary>
    /// Generic Singleton pattern for "Controllers"
    /// </summary>
    /// <typeparam name="T">Singleton type</typeparam>
    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance = null;
        public static T instance {
            set {
                _instance = value;
            }
            get {
                if(_instance == null) {
                    _instance = FindObjectOfType<T>();
                }

                return _instance;
            }
        }

        private static bool firstInit = true;

        public virtual void Awake()
        {
            if (firstInit) {
                firstInit = false;

                DontDestroyOnLoad(gameObject);
                instance = this as T;
            } else {
                if (instance == null) {
                    DontDestroyOnLoad(gameObject);
                    instance = this as T;
                } else {
                    Destroy(gameObject);
                }
            }
        }
    }
}