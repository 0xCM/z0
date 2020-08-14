//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(EmitParsedReport), StepName)]
    public readonly struct EmitParsedReportStep
    {
        public const string StepName = nameof(EmitParsedReport);
    }
}