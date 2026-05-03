using System;

namespace BZGraphProcessor.Shared
{
    public static class TypeCache<T>
    {
        public static readonly Type TYPE = typeof(T);
        
        public static readonly int HASH = TYPE.GetHashCode();

        public static readonly long LONG_HASH = TYPE.TypeHandle.Value.ToInt64();
    }
}