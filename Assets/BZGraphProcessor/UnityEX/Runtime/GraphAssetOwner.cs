

using System;
using BZGraphProcessor.Shared;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace BZGraphProcessor
{
    public abstract class GraphAssetOwner<TGraphAsset, TGraph> : MonoBehaviour, IGraphAssetOwner
        where TGraphAsset : UnityObject, IGraphAsset
        where TGraph : BaseGraphProcessor
    {
        #region Fields
        [NonSerialized]
        private TGraph graph = null;
        [SerializeField]
        private TGraphAsset graphAsset = null;
        #endregion

        #region Properties
        
        public IGraphAsset GraphAsset
        {
            get { return graphAsset; }
        }

        public BaseGraphProcessor Graph
        {
            get { return T_Graph; }
        }

        public TGraphAsset T_GraphAsset
        {
            get { return graphAsset; }
        }

        public virtual TGraph T_Graph
        {
            get
            { 
                if (graph == null && graphAsset != null)
                {
                    var graphData = graphAsset.LoadGraph()?.Clone();
                    var validation = GraphValidationUtil.Repair(graphData);
                    graph = ViewModelFactory.ProduceViewModel(graphData) as TGraph;
                    graph?.AppendDiagnostics(validation.Messages);
                }
                
                return graph;
            }
            set { graph = value; }
        }
        #endregion
    }
}
