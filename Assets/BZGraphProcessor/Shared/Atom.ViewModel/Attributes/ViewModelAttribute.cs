using System;

namespace BZGraphProcessor.Shared
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ViewModelAttribute : Attribute
    {
        public Type m_ModelType;

        public Type ModelType
        {
            get { return m_ModelType; }
        }
        
        public ViewModelAttribute(Type modelType)
        {
            this.m_ModelType = modelType;
        }
    }
}
