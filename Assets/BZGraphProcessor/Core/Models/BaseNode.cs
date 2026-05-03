

using System;

namespace BZGraphProcessor
{
#if UNITY_5_4_OR_NEWER
    [Serializable]
    public abstract class BaseNode
    {
        [UnityEngine.HideInInspector] public long id;
        [UnityEngine.HideInInspector] public InternalVector2Int position;
    }
#else
    [Serializable]
    public abstract class BaseNode
    {
        public long id;
        public InternalVector2Int position;
    }
#endif
}