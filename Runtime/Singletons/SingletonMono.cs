using UnityEngine;

namespace SeriousLib.Singleton
{
    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T instance;

        public virtual void Awake()
        {
            if (instance == null) {
                DontDestroyOnLoad(gameObject);
                instance = this as T;
            } else {
                Destroy(gameObject);
            }
        }
    }
}