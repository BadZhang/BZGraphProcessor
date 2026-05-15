

using System;
using System.Collections.Generic;

namespace BZGraphProcessor
{
    [Serializable]
    public sealed class Group
    {
        public long id;
        public string groupName;
        public InternalVector2Int position;
        public InternalVector2Int size;
        public InternalColor backgroundColor = new(0.3f, 0.3f, 0.3f, 0.3f);
        public List<long> nodes = new();
    }
}