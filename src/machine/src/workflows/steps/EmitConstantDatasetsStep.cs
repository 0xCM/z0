//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;

    [Step(WfStepId.EmitConstantDatasets, true)]
    public readonly struct EmitConstantDatasetsStep
    {
        public const string WorkerName = nameof(EmitConstantDatasets);

        public const WfStepId StepId = WfStepId.EmitConstantDatasets;
    }
}