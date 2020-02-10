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

    public readonly struct CaptureDataset
    {        
        public static CaptureDataset Define(OpIdentity id, CaptureOutcome outcome, byte[] consumed, byte[] trimmed)
            => new CaptureDataset(id,outcome, consumed,trimmed);

        CaptureDataset(OpIdentity id, CaptureOutcome outcome, byte[] buffer, byte[] trimmed)
        {
            this.Id = id;
            this.FinalState = outcome.State;
            this.Start = outcome.Start;
            this.End = outcome.End;
            this.ByteCount = outcome.ByteCount;
            this.TermCode = outcome.TermCode;
            this.Consumed = buffer;
            this.Trimmed = trimmed;
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

        public readonly byte[] Consumed;

        public readonly byte[] Trimmed;

        public CaptureOutcome Outcome
            => CaptureOutcome.Define(FinalState, Start, End, TermCode);
    }


}