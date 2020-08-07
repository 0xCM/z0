//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;

    [Step(Kind, true)]
    public readonly struct EmitConstantDatasetsStep
    {
        public const WfStepKind Kind = WfStepKind.EmitConstantDatasets;        
        
        public const string Name = nameof(EmitConstantDatasets);       
    }
}