#if UNITY_EDITOR
using UnityEngine.UIElements;

namespace BZGraphProcessor.Editor
{
    public class BaseVisualElement : VisualElement
    {
        public enum ChildChangedType
        {
            Added,
            Removed
        }
        
        public class ChildChangedEvent : EventBase<ChildChangedEvent>
        {
            public ChildChangedType Type;
            public VisualElement Target;
        }

        public new void Add(VisualElement child)
        {
            base.Add(child);
            var evt = ChildChangedEvent.GetPooled();
            evt.Type = ChildChangedType.Added;
            evt.Target = child;
            this.SendEvent(evt);
        }

        public new void Remove(VisualElement child)
        {
            base.Remove(child);
            var evt = ChildChangedEvent.GetPooled();
            evt.Type = ChildChangedType.Removed;
            evt.Target = child;
            this.SendEvent(evt);
        }
    }
}
#endif