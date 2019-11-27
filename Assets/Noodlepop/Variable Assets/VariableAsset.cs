using System;
using UnityEngine;

namespace Noodlepop.VariableAssets
{
    /// <summary>
    /// A variable that lives in your assets folder.  It can be marked as readonly or modified
    /// at runtime.  Runtime values are not saved. Default values are. (I think)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class VariableAsset<T> : ScriptableObject
    {
        [SerializeField] protected bool _readOnly = false;
        [SerializeField] protected T _defaultValue;
        [SerializeField] protected T _value;

        private Component _owner;

        public T DefaultValue
        {
            get { return _defaultValue; }
        }

        public T Value
        {
            get { return _value; }
            set
            {
                if (!_readOnly)
                {
                    if(_owner)
                        throw new Exception($"[VariableAsset] This asset is locked and can only be modified by component: {_owner.name}");
                    
                    _value = value;
                }
                else
                {
                    LogReadOnlyWarning();
                }
            }
        }

        /// <summary>
        /// Lock this variable so its value cannot be changed except with a reference to the component that locked it.
        /// Not great but at least demonstrates how this variable is meant to be used.
        /// </summary>
        /// <param name="owner"></param>
        public void Lock(Component owner)
        {
            _owner = owner;
        }

        /// <summary>
        /// Unlock this variable.
        /// </summary>
        /// <param name="owner"></param>
        public void Unlock(Component owner)
        {
            if (_owner == owner)
                _owner = null;
        }

        public void SetValueSafe(T value, Component owner)
        {
            if(_owner == null || owner == _owner)
                _value = value;
        }

        public void OnEnable()
        {
            _value = _defaultValue;
        }

        public void Init(T value)
        {
            _defaultValue = value;
            _value = value;
        }

        private void LogReadOnlyWarning()
        {
            Debug.LogWarningFormat("Tried changing read-only property {0}<{1}>", this.name, this.GetType().ToString());
        }
    }
}