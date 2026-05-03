
#if UNITY_EDITOR
using BZGraphProcessor.Shared.Unity;
using UnityEngine;
using UnityEditor;

namespace BZGraphProcessor.Shared.UnityEditors
{
    [global::UnityEditor.CustomPropertyDrawer(typeof(HideLabelAttribute))]
    public class HideLabelDrawer : global::UnityEditor.PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            //base.OnGUI(position, property, label);
            EditorGUI.PropertyField(position, property, GUIContent.none);
        }
    }
}
#endif