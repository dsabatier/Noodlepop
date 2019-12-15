using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Noodlepop.GameEvents
{
    public class StringGameEventListener : GameEventListener<string>
    {
        [SerializeField] private StringUnityEvent _unityEvent;
        protected override UnityEvent<string> _onInvoke => _unityEvent;

        [SerializeField] private StringGameEvent _event;
        protected override GameEvent<string> _gameEvent => _event;
    }
}