//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes the outcome of a native capture operation
    /// </summary>
    public readonly struct CaptureOutcome
    {
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
        public CaptureOutcome(in ExtractState state, MemoryRange range, ExtractTermCode cc)
        {
            State = state;
            Range = range;
            TermCode = cc;
        }

        public ulong Start
        {
            [MethodImpl(Inline)]
            get => Range.Start;
        }

        public ulong End
        {
            [MethodImpl(Inline)]
            get => Range.End;
        }

        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => (int)Range.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => End - Start == 0 && TermCode == ExtractTermCode.None;
        }

        public static CaptureOutcome Empty
            => new CaptureOutcome(ExtractState.Empty, MemoryRange.Empty, 0);
    }
}