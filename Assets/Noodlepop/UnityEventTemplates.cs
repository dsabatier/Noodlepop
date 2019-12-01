using System;
using UnityEngine;
using UnityEngine.Events;


// Templates for UnityEvents.
#region Game specific types:

#endregion

#region Primitives and Unity types:
[Serializable] public class Vector3UnityEvent : UnityEvent<Vector3> { }
[Serializable] public class Vector2UnityEvent : UnityEvent<Vector2> { }
[Serializable] public class BoolUnityEvent : UnityEvent<bool> { }
[Serializable] public class StringUnityEvent : UnityEvent<string> { }
[Serializable] public class IntUnityEvent : UnityEvent<int> { }
[Serializable] public class FloatUnityEvent : UnityEvent<float> { }
[Serializable] public class RayUnityEvent : UnityEvent<Ray> { }
[Serializable] public class GameObjectUnityEvent : UnityEvent<GameObject> { }
#endregion