
using System;

using UnityObject = UnityEngine.Object;

namespace BZGraphProcessor
{
    public interface IGraphAssetOwner : IGraphOwner
    {
        IGraphAsset GraphAsset { get; }
    }
}
