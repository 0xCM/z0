//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static CaptureWorkflowEvents;

    public interface ICatalogCaptureBroker : IStepBroker
    {
        ClearedDirectory ClearedDirectory => ClearedDirectory.Empty;        

        MatchedEmissions MatchedEmissions => MatchedEmissions.Empty;        

        CapturingPart CapturingPart => CapturingPart.Empty;

        CapturedPart CapturedPart => CapturedPart.Empty;
    }
}