//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(WfStepId.RunProcessors, true)]
    public readonly struct RunProcessorsStep
    {
        public const string WorkerName = nameof(RunProcessors);
    }
}