//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Konst;

    [Step(true)]
    public readonly struct ManagePartCaptureStep
    {
        public const WfStepKind StepId = WfStepKind.ManagePartCapture;

        public const string WorkerName = nameof(ManagePartCapture);
    }
}