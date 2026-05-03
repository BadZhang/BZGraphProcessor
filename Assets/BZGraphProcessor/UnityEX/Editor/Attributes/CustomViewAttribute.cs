
#if UNITY_EDITOR
using System;

namespace BZGraphProcessor.Editor
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CustomViewAttribute : Attribute
    {
        public Type targetType;

        public CustomViewAttribute(Type targetType)
        {
            this.targetType = targetType;
        }
    }
}
#endif