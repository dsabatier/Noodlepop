using UnityEngine;

namespace Noodlepop.SingletonPattern
{
    /// <summary>
    /// Base class for all singletons.
    /// </summary>
    /// <typeparam name="T">Type of the inheriting class.</typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;

        protected static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    T newSingleton = new GameObject().AddComponent<T>();
                    newSingleton.gameObject.name = $"New {typeof(T)} (Lazy Load)";
                    _instance = newSingleton;
                }
                
                return _instance;
            }
        }
        
        protected virtual void Awake()
        {
            if (_instance != null)
            {
                Debug.LogError("Trying to instantiate a second instance of a singleton.");
            }
            else
            {
                _instance = this as T;
            }
        }
        
        protected virtual void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }
    }
}