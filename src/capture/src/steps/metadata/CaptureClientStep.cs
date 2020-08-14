//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(CaptureClient), StepName)]
    public readonly struct CaptureClientStep
    {
        public const string StepName = nameof(CaptureClient);
    }
}