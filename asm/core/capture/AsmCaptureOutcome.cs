//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct AsmCaptureOutcome
    {
        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly AsmCaptureState State;

        /// <summary>
        /// The origin of the captured data
        /// </summary>
        public readonly MemoryRange Range;

        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public readonly CaptureTermCode TermCode;

        public static AsmCaptureOutcome Empty => Define(AsmCaptureState.Empty, 0,0, CaptureTermCode.None);

        [MethodImpl(Inline)]
        public static AsmCaptureOutcome Define(in AsmCaptureState state, ulong start, ulong end, CaptureTermCode cc)
            => new AsmCaptureOutcome(state, (start, end), cc);

        [MethodImpl(Inline)]
        public static AsmCaptureOutcome Define(in AsmCaptureState state, MemoryRange source, CaptureTermCode cc)
            => new AsmCaptureOutcome(state, source, cc);


        [MethodImpl(Inline)]
        AsmCaptureOutcome(in AsmCaptureState state, MemoryRange range, CaptureTermCode cc)
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