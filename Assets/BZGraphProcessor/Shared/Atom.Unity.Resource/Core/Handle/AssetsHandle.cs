using System;
using System.Collections.Generic;
using UnityObject = UnityEngine.Object;

namespace BZGraphProcessor.Shared
{
    public abstract class AssetsHandleBase : HandleBase
    {
        public abstract IReadOnlyList<UnityObject> Assets { get; }

        public abstract event Action<AssetsHandleBase> OnCompleted;

        public abstract void Release();

        public void Dispose() => this.Release();
    }
}