using BZGraphProcessor;
using System;
using BZGraphProcessor.Shared;

[Serializable]
public class SampleGraph : BaseGraph { }

[ViewModel(typeof(SampleGraph))]
public class SampleGraphProcessor : BaseGraphProcessor
{
    public SampleGraphProcessor(BaseGraph model) : base(model) { }
}
