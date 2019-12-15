using UnityEditor;
using UnityEngine;

namespace Noodlepop.GameEvents
{
    [CustomEditor(typeof(GameEventBase), true)]
    public class GameEventBaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginDisabledGroup(serializedObject.isEditingMultipleObjects);
            if (GUILayout.Button("Raise"))
            {
                ((GameEventBase) target).Raise();
            }
            EditorGUI.EndDisabledGroup();
            
            DrawDefaultInspector();
        }
    }
}
