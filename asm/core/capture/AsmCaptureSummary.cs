//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct AsmCaptureSummary
    {        
        public readonly AsmCaptureOutcome Outcome;

        public readonly AsmCaptureBits Bits;

        [MethodImpl(Inline)]
        public static AsmCaptureSummary Define(AsmCaptureOutcome outcome, AsmCaptureBits bits)
            => new AsmCaptureSummary(outcome, bits);

        [MethodImpl(Inline)]
        AsmCaptureSummary(AsmCaptureOutcome outcome, AsmCaptureBits bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}