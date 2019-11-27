using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Noodlepop.GameEvents
{
    public class IntGameEventListener : GameEventListener<int>
    {
        [SerializeField] private IntUnityEvent _unityEvent;
        protected override UnityEvent<int> _onInvoke => _unityEvent;

        [SerializeField] private IntGameEvent _event;
        protected override GameEvent<int> _gameEvent => _event;
    }
}