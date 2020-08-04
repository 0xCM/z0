//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Step(true)]
    public readonly struct EmitParsedReportStep
    {
        public const WfStepId StepId = WfStepId.EmitParsedReport;

        public const string WorkerName = nameof(EmitParsedReport);
    }
}