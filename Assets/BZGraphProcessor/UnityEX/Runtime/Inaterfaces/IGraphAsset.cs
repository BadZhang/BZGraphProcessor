
using System;

namespace BZGraphProcessor
{
    public interface IGraphAsset
    {
        Type GraphType { get; }
        
        void SaveGraph(BaseGraph graph);
        
        BaseGraph LoadGraph();
    }
}