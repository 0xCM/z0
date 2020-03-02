//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct CaptureSummary
    {        
        public readonly AsmCaptureOutcome Outcome;

        public readonly AsmCaptureBits Bits;

        [MethodImpl(Inline)]
        public static CaptureSummary Define(AsmCaptureOutcome outcome, AsmCaptureBits bits)
            => new CaptureSummary(outcome, bits);

        [MethodImpl(Inline)]
        CaptureSummary(AsmCaptureOutcome outcome, AsmCaptureBits bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}