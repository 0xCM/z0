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
        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly CaptureState State;

        /// <summary>
        /// The origin of the captured data
        /// </summary>
        public readonly MemoryRange Range;

        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public readonly CaptureTermCode TermCode;

        public static CaptureOutcome Empty => Define(CaptureState.Empty, 0,0, CaptureTermCode.None);

        public static CaptureOutcome Define(in CaptureState state, ulong start, ulong end, CaptureTermCode cc)
            => new CaptureOutcome(state, (start, end), cc);

        public static CaptureOutcome Define(in CaptureState state, MemoryRange source, CaptureTermCode cc)
            => new CaptureOutcome(state, source, cc);

        CaptureOutcome(in CaptureState state, MemoryRange range, CaptureTermCode cc)
        {   
            this.State = state;
            this.Range = range;
            this.TermCode = cc;
        }
         

        public ulong Start
            => Range.Start;

        public ulong End
            => Range.End;

        public int ByteCount
            => (int)Range.Length;

        public bool IsEmpty
            => End - Start == 0 && TermCode == CaptureTermCode.None;        
    }
}