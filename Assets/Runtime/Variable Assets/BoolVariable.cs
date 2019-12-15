using UnityEngine;

namespace Noodlepop.VariableAssets
{
    [CreateAssetMenu(fileName = "New Boolean Variable", menuName = "Variable Assets/New Boolean")]
    public class BoolVariable : VariableAsset<bool>
    {
        public override bool Equals(object valueToCheck)
        {
            if (valueToCheck is bool)
                return _value == (bool) valueToCheck;

            if (valueToCheck is BoolVariable)
                return _value == (valueToCheck as BoolVariable).Value;

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

        public static implicit operator bool(BoolVariable boolVariable)
        {
            return boolVariable.Value;
        }
    }
}