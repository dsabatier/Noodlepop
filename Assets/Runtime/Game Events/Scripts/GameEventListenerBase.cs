using UnityEngine;
using UnityEngine.Events;

namespace Noodlepop.GameEvents
{
    public abstract class GameEventListenerBase : MonoBehaviour
    {
        public abstract void Raise();
    }

    public abstract class GameEventListener<T> : GameEventListenerBase
    {
        protected abstract UnityEvent<T> _onInvoke { get; }
        protected abstract GameEvent<T> _gameEvent { get; }

        private void OnEnable()
        {
            _gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            _gameEvent.UnregisterListener(this);
        }

        public override void Raise()
        {
            throw new System.NotImplementedException();
        }

        public void Raise(T value)
        {
            _onInvoke?.Invoke(value);
        }
    }
}