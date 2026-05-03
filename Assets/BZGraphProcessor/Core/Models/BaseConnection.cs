

using System;

namespace BZGraphProcessor
{
#if UNITY_5_3_OR_NEWER
    [Serializable]
    public class BaseConnection
    {
        [UnityEngine.HideInInspector] public long fromNode;
        [UnityEngine.HideInInspector] public string fromPort;
        [UnityEngine.HideInInspector] public long toNode;
        [UnityEngine.HideInInspector] public string toPort;
    }
#else
    [Serializable]
    public class BaseConnection
    {
        public long fromNode;
        public string fromPort;
        public long toNode;
        public string toPort;
    }
#endif
}