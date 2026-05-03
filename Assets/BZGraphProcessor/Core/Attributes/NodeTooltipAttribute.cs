
using System;

namespace BZGraphProcessor
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class NodeTooltipAttribute : Attribute
    {
        public readonly string Tooltip;
        
        public NodeTooltipAttribute(string tooltip)
        {
            Tooltip = tooltip;
        }
    }
}
