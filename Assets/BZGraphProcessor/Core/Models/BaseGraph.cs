

using System;
using System.Collections.Generic;

namespace BZGraphProcessor
{
#if UNITY_5_3_OR_NEWER
    [Serializable]
    public class BaseGraph
    {
        public float zoom = 1;
        public InternalVector2Int pan = new InternalVector2Int(0, 0);
        [UnityEngine.SerializeReference] public List<BaseNode> nodes = new List<BaseNode>();
        [UnityEngine.SerializeReference] public List<BaseConnection> connections = new List<BaseConnection>();
        public List<Group> groups = new List<Group>();
        public List<StickyNote> notes = new List<StickyNote>();
        public List<PlacematData> placemats = new List<PlacematData>();
    }
#else
    [Serializable]
    public class BaseGraph
    {
        public float zoom = 1;
        public InternalVector2Int pan = new InternalVector2Int(0, 0);
        public List<BaseNode> nodes = new List<BaseNode>();
        public List<BaseConnection> connections = new List<BaseConnection>();
        public List<Group> groups = new List<Group>();
        public List<StickyNote> notes = new List<StickyNote>();
        public List<PlacematData> placemats = new List<PlacematData>();
    }
#endif
}
