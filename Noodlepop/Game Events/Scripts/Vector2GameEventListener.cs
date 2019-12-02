using System.Collections;
using System.Collections.Generic;
using Noodlepop.GameEvents;
using UnityEngine;
using UnityEngine.Events;

public class Vector2GameEventListener : GameEventListener<Vector2>
{
    [SerializeField] private Vector2UnityEvent _unityEvent;
    protected override UnityEvent<Vector2> _onInvoke => _unityEvent;

    [SerializeField] private Vector2GameEvent _event;
    protected override GameEvent<Vector2> _gameEvent => _event;
}
