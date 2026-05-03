#if UNITY_EDITOR
using BZGraphProcessor.Shared.Unity;
using BZGraphProcessor.Shared.UnityEditors;
using UnityEditor;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace BZGraphProcessor.Shared.UnityEditors
{
    [@CustomPropertyDrawer(typeof(ObjectPreviewButtonAttribute), true)]
    public class ObjectPreviewButtonDrawer : global::UnityEditor.PropertyDrawer
    {
        public class ObjectPreviewPopupWindow : PopupWindowContent
        {
            UnityEditor.Editor editor;
            UnityObject unityObject;
            Vector2 scroll;
            public ObjectPreviewPopupWindow(UnityObject _unityObject)
            {
                unityObject = _unityObject;
                editor = UnityEditor.Editor.CreateEditor(_unityObject);
            }

            public override Vector2 GetWindowSize()
            {
                return new Vector2(300, 400);
            }

            public override void OnGUI(Rect rect)
            {
                //if (Event.current.type == EventType.MouseDrag && rect.Contains(Event.current.mousePosition))
                //{
                //    Rect p = editorWindow.position;
                //    p.position += Event.current.delta;
                //    editorWindow.position = p;
                //    Event.current.Use();
                //}
                scroll = EditorGUILayout.BeginScrollView(scroll);
                if (editor != null)
                {
                    editor.DrawHeader();
                    editor.OnInspectorGUI();
                }
                EditorGUILayout.EndScrollView();
            }
        }

        ObjectPreviewPopupWindow popupWindow;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.xMax -= 20;
            EditorGUI.PropertyField(position, property, label, true);
            position.xMin = position.xMax;
            position.xMax += 20;
            if (GUI.Button(position, EditorGUIUtility.IconContent("search_menu"), EditorStylesExtension.OnlyIconButtonStyle))
            {
                if (popupWindow == null)
                    popupWindow = new ObjectPreviewPopupWindow(property.objectReferenceValue);
                PopupWindow.Show(position, popupWindow);
            }
        }
    }
}
#endif