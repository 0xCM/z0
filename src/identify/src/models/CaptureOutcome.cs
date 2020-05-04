//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct CaptureOutcome : IIdentified<OpIdentity>
    {
        public static CaptureOutcome Empty => Define(ExtractState.Empty, 0,0, ExtractTermCode.None);

        /// <summary>
        /// The identity of the capture subject
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly ExtractState State;

        /// <summary>
        /// The origin of the captured data
        /// </summary>
        public readonly MemoryRange Range;

        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public static CaptureOutcome Define(in ExtractState state, ulong start, ulong end, ExtractTermCode cc)
            => new CaptureOutcome(state, (start, end), cc);

        [MethodImpl(Inline)]
        public static CaptureOutcome Define(in ExtractState state, MemoryRange source, ExtractTermCode cc)
            => new CaptureOutcome(state, source, cc);

        [MethodImpl(Inline)]
        CaptureOutcome(in ExtractState state, MemoryRange range, ExtractTermCode cc)
        {   
            Id = state.Id;
            State = state;
            Range = range;
            TermCode = cc;
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