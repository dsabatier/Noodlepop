using System;
using UnityEditor;
using UnityEngine;
 
[CustomPropertyDrawer (typeof (SceneReferenceAttribute))]
public class SceneReferenceDrawer : PropertyDrawer 
{
    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) 
    {
        var sceneObject = GetSceneObject(property.stringValue);
        var scene = EditorGUI.ObjectField(position, label, sceneObject, typeof(SceneAsset), true);
        if (scene == null) 
        {
            property.stringValue = string.Empty;
        } 
        else if (scene.name != property.stringValue)
        {
            var sceneObj = GetSceneObject(scene.name);
            if (sceneObj == null) 
            {
                Debug.LogWarning($"{scene.name} not found in build settings!");
            } 
            else 
            {
                property.stringValue = scene.name;
            }
        }
    }
    private static SceneAsset GetSceneObject(string sceneObjectName) 
    {
        if (string.IsNullOrEmpty(sceneObjectName))
            return null;

        foreach (var editorScene in EditorBuildSettings.scenes) 
        {
            if (editorScene.path.IndexOf(sceneObjectName, StringComparison.Ordinal) != -1) {
                return AssetDatabase.LoadAssetAtPath(editorScene.path, typeof(SceneAsset)) as SceneAsset;
            }
        }
        
        Debug.LogWarning("Scene [" + sceneObjectName + "] cannot be used. Add this scene to the 'Scenes in the Build' in build settings.");
        return null;
    }
}