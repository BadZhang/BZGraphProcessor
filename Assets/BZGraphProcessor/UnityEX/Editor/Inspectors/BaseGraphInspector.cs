#if UNITY_EDITOR
using BZGraphProcessor.Shared;
using UnityEngine;
using Sirenix.OdinInspector.Editor;
using BZGraphProcessor.Shared.UnityEditors;

namespace BZGraphProcessor.Editor
{
    [CustomObjectEditor(typeof(BaseGraphView))]
    public class BaseGraphInspector : ObjectEditor
    {
        static readonly GUIHelper.ContextDataCache ContextDataCache = new();

        protected PropertyTree propertyTree;

        public override void OnEnable()
        {
            var view = Target as BaseGraphView;
            if (view.ViewModel != null)
                propertyTree = PropertyTree.Create(view.ViewModel.Model);
        }

        public override void OnInspectorGUI()
        {
            var view = Target as BaseGraphView;
            if (view == null || view.ViewModel == null)
                return;

            if (!ContextDataCache.TryGetContextData<GUIStyle>("BigLabel", out var bigLabel))
            {
                bigLabel.value = new GUIStyle(GUI.skin.label);
                bigLabel.value.fontSize = 18;
                bigLabel.value.fontStyle = FontStyle.Bold;
                bigLabel.value.alignment = TextAnchor.MiddleLeft;
                bigLabel.value.stretchWidth = true;
            }

            EditorGUILayoutExtension.BeginVerticalBoxGroup();
            GUILayout.Label(string.Concat("Nodes：", view.ViewModel.Nodes.Count), bigLabel.value);
            GUILayout.Label(string.Concat("Connections：", view.ViewModel.Connections.Count), bigLabel.value);
            GUILayout.Label(string.Concat("Groups：", view.ViewModel.Groups.GroupMap.Count), bigLabel.value);
            EditorGUILayoutExtension.EndVerticalBoxGroup();
        }

        public override void OnDisable()
        {
            base.OnDisable();
            propertyTree?.Dispose();
        }
    }
}
#endif