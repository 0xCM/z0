//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Step(true)]
    public readonly struct EmitParsedReportStep
    {
        public const WfStepKind StepId = WfStepKind.EmitParsedReport;

        public const string WorkerName = nameof(EmitParsedReport);
    }
}