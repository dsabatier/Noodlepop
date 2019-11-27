using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Noodlepop.GameEvents
{
    [System.Serializable]
    public class SimpleGameEventListener : GameEventListenerBase
    {
        [SerializeField] private SimpleGameEvent _gameEvent;
        [SerializeField] protected UnityEvent _onInvoke;
        
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
            _onInvoke?.Invoke();
        }
    }
}