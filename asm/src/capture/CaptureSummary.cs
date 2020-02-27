//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;    

    public readonly struct CaptureSummary
    {        
        public readonly CaptureOutcome Outcome;

        public readonly CaptureBits Bits;

        [MethodImpl(Inline)]
        public static CaptureSummary Define(CaptureOutcome outcome, CaptureBits bits)
            => new CaptureSummary(outcome, bits);

        [MethodImpl(Inline)]
        CaptureSummary(CaptureOutcome outcome, CaptureBits bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }

        public MemoryRange Range
            => Outcome.Range;
    }

 
}