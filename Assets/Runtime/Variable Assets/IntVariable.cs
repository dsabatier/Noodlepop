using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Noodlepop.VariableAssets
{
    [CreateAssetMenu(fileName = "New Integer Variable", menuName = "Variable Assets/New Integer Variable")]
    public class IntVariable : VariableAsset<int>
    {
        public override bool Equals(object valueToCheck)
        {
            if (valueToCheck is int)
                return _value == (int) valueToCheck;

            if (valueToCheck is IntVariable)
                return _value == (valueToCheck as IntVariable).Value;

            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public static implicit operator int(IntVariable intVariable)
        {
            return intVariable.Value;
        }
    }
}