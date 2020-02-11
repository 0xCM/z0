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
        [MethodImpl(Inline)]
        public static CaptureSummary Define(OpIdentity id, CaptureOutcome outcome, CaptureBits bits)
            => new CaptureSummary(id,outcome, bits);

        [MethodImpl(Inline)]
        CaptureSummary(OpIdentity id, CaptureOutcome outcome, CaptureBits bits)
        {
            this.Id = id;
            this.FinalState = outcome.State;
            this.Start = outcome.Start;
            this.End = outcome.End;
            this.ByteCount = outcome.ByteCount;
            this.TermCode = outcome.TermCode;
            this.Bits = bits;

        }
        
        public readonly OpIdentity Id;

        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly CaptureState FinalState;
        
        public readonly ulong Start;

        public readonly ulong End;

        public readonly int ByteCount;

        public readonly CaptureTermCode TermCode;

        public readonly CaptureBits Bits;

        public CaptureOutcome Outcome
            => CaptureOutcome.Define(FinalState, Start, End, TermCode);
    }


}