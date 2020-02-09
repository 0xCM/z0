//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct CaptureOutcome
    {
        public static CaptureOutcome Empty => Define(CaptureState.Empty, 0,0, CaptureTermCode.None);

        public static CaptureOutcome Define(in CaptureState state, ulong start, ulong end, CaptureTermCode cc)
            => new CaptureOutcome(state,start, end, cc);

        CaptureOutcome(in CaptureState state, ulong start, ulong end, CaptureTermCode cc)
        {   
            this.State = state;
            this.Start = start;
            this.End = end;
            this.ByteCount = (int)(end - start);
            this.TermCode = cc;
        }
         
        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly CaptureState State;
        
        public readonly ulong Start;

        public readonly ulong End;

        public readonly int ByteCount;

        public readonly CaptureTermCode TermCode;

        public MemoryRange Range
            => (Start,End);

        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;        
    }
}