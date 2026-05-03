#if UNITY_EDITOR
using BZGraphProcessor.Shared.UnityEditors;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace BZGraphProcessor.Editor
{
    [CustomObjectEditor(typeof(BaseConnectionView))]
    public class BaseConnectionInspector : ObjectEditor
    {
        PropertyTree propertyTree;

        public override void OnEnable()
        {
            var view = Target as BaseNodeView;
            if (view == null || view.ViewModel == null)
                return;
            // if (view.BindingProperty != null)
            // {
            // }
            // else
            {
                propertyTree = PropertyTree.Create(view.ViewModel.Model);
                propertyTree.DrawMonoScriptObjectField = true;
            }
        }

        public override sealed void OnInspectorGUI()
        {
            var view = Target as BaseConnectionView;
            if (view == null || view.ViewModel == null)
                return;

            if (propertyTree != null)
            {
                propertyTree.BeginDraw(false);
                foreach (var property in propertyTree.EnumerateTree(false, true))
                {
                    switch (property.Name)
                    {
                        case nameof(BaseConnection.fromNode):
                        case nameof(BaseConnection.fromPort):
                        case nameof(BaseConnection.toNode):
                        case nameof(BaseConnection.toPort):
                            continue;
                    }
                    property.Draw();
                }
                propertyTree.EndDraw();
                SourceEditor.Repaint();
            }
        }

        public override void OnDisable()
        {
            base.OnDisable();
            propertyTree?.Dispose();
        }
    }
}
#endif