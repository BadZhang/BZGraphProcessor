
#if UNITY_EDITOR
using BZGraphProcessor.Shared.Unity;
using UnityEditor;
using UnityEngine;

namespace BZGraphProcessor.Shared.UnityEditors
{
    [global::UnityEditor.CustomPropertyDrawer(typeof(ReadOnlyAttribute), true)]
    public class ReadOnlyDrawer : global::UnityEditor.PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.PropertyField(position, property, label, true);
            EditorGUI.EndDisabledGroup();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, true);
        }
    }
}
#endif