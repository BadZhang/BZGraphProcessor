
#if UNITY_EDITOR
using BZGraphProcessor.Shared.Unity;
using UnityEditor;
using UnityEngine;

namespace BZGraphProcessor.Shared.UnityEditors
{
    [global::UnityEditor.CustomPropertyDrawer(typeof(PreviewObjectFieldAttribute), true)]
    public class PreviewObjectFieldDrawer : global::UnityEditor.PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            property.objectReferenceValue = EditorGUILayout.ObjectField(label, property.objectReferenceValue as Texture2D, typeof(Texture2D), false);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, true);
        }
    }
}
#endif