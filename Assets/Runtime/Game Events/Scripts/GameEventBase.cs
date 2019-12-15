using System.Collections.Generic;
using UnityEngine;

namespace Noodlepop.GameEvents
{
    public abstract class GameEventBase : ScriptableObject
    {
        private readonly List<GameEventListenerBase> _registeredListeners = new List<GameEventListenerBase>();

        public void RegisterListener(GameEventListenerBase listener)
        {
            if (!_registeredListeners.Contains(listener))
                _registeredListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListenerBase listener)
        {
            if (_registeredListeners.Contains(listener))
                _registeredListeners.Remove(listener);
        }

        public virtual void Raise()
        {
            foreach (GameEventListenerBase listener in _registeredListeners)
            {
                listener.Raise();
            }
        }
    }

    public abstract class GameEvent<T> : GameEventBase
    {
        [SerializeField] protected T _value;
        
        protected readonly List<GameEventListener<T>> _registeredListeners = new List<GameEventListener<T>>();
        
        public void RegisterListener(GameEventListener<T> listener)
        {
            if (!_registeredListeners.Contains(listener))
                _registeredListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener<T> listener)
        {
            if (_registeredListeners.Contains(listener))
                _registeredListeners.Remove(listener);
        }
        
        public void Raise(T value)
        {
            foreach (GameEventListener<T> listener in _registeredListeners)
            {
                listener.Raise(value);
            }
        }
        
        public override void Raise()
        {
            foreach (GameEventListener<T> listener in _registeredListeners)
            {
                listener.Raise(_value);
            }
        }
    }
}