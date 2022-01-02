using UnityEngine;

namespace SeriousLib.Singleton
{
    /// <summary>
    /// Generic Singleton pattern for "Controllers"
    /// </summary>
    /// <typeparam name="T">Singleton type</typeparam>
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