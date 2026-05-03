using UnityEngine;

namespace BZGraphProcessor.UnityEX.Editor
{
    public class InspectObject : ScriptableObject
    {
        [SerializeReference]
        public BaseGraph graph;
    }
}