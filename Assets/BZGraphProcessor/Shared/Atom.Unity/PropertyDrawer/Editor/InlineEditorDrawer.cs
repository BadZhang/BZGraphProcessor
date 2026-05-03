
#if UNITY_EDITOR
using BZGraphProcessor.Shared.Unity;
using UnityEditor;
using UnityEngine;

namespace BZGraphProcessor.Shared.UnityEditors
{
    [global::UnityEditor.CustomPropertyDrawer(typeof(InlineEditorAttribute))]
    public class InlineEditorDrawer : global::UnityEditor.PropertyDrawer
    {
        UnityEditor.Editor editor;
        bool foldout;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField(position, property, label);
            if (EditorGUI.EndChangeCheck() && property.objectReferenceValue != null)
                editor = UnityEditor.Editor.CreateEditor(property.objectReferenceValue);

            foldout = EditorGUI.Foldout(position, foldout, string.Empty, true);
            if (foldout)
            {
                if (property.objectReferenceValue != null)
                {
                    if (editor == null)
                        editor = UnityEditor.Editor.CreateEditor(property.objectReferenceValue);
                    editor.OnInspectorGUI();
                }
            }
        }
    }
}
#endif