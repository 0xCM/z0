//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
    
    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct ExtractionOutcome
    {
        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly ExtractionState State;

        /// <summary>
        /// The origin of the captured data
        /// </summary>
        public readonly MemoryRange Range;

        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public readonly ExtractTermCode TermCode;

        public static ExtractionOutcome Empty => Define(ExtractionState.Empty, 0,0, ExtractTermCode.None);

        [MethodImpl(Inline)]
        public static ExtractionOutcome Define(in ExtractionState state, ulong start, ulong end, ExtractTermCode cc)
            => new ExtractionOutcome(state, (start, end), cc);

        [MethodImpl(Inline)]
        public static ExtractionOutcome Define(in ExtractionState state, MemoryRange source, ExtractTermCode cc)
            => new ExtractionOutcome(state, source, cc);

        [MethodImpl(Inline)]
        ExtractionOutcome(in ExtractionState state, MemoryRange range, ExtractTermCode cc)
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
            => End - Start == 0 && TermCode == ExtractTermCode.None;        
    }
}