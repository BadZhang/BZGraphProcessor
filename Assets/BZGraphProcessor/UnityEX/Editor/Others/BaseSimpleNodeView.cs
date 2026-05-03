
#if UNITY_EDITOR
using UnityEngine.UIElements;

namespace BZGraphProcessor.Editor
{
    public abstract class BaseSimpleNodeView<M> : BaseNodeView<M> where M : BaseNodeProcessor
    {
        protected BaseSimpleNodeView() : base()
        {
            this.AddToClassList("simple-node-view");
            styleSheets.Add(GraphProcessorEditorStyles.DefaultStyles.BaseSimpleNodeViewStyle);
            m_CollapseButton.style.display = DisplayStyle.None;
        }
    }

    public class BaseSimpleNodeView : BaseSimpleNodeView<BaseNodeProcessor> { }
}
#endif