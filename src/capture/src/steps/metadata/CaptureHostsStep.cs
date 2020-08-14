//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Step(typeof(CaptureHosts), StepName)]
    public readonly struct CaptureHostsStep
    {        
        public const string StepName = nameof(CaptureHosts);
    }
}