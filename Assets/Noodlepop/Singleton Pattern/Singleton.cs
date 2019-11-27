﻿using System.Collections;
using System.Collections.Generic;
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
        protected static T Instance => _instance;

        public static bool IsInitialized => _instance != null;

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