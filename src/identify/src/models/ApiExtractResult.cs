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
    public readonly struct ApiExtractResult
    {
        /// <summary>
        /// The final state in the capture process
        /// </summary>
        public readonly ApiExtractState State;

        /// <summary>
        /// The origin of the captured data
        /// </summary>
        public readonly MemoryRange Range;

        /// <summary>
        /// The capture termination code indicating why the capture process reached end-state
        /// </summary>
        public readonly ExtractTermCode TermCode;

        public static ApiExtractResult Empty => Define(ApiExtractState.Empty, 0,0, ExtractTermCode.None);

        [MethodImpl(Inline)]
        public static ApiExtractResult Define(in ApiExtractState state, ulong start, ulong end, ExtractTermCode cc)
            => new ApiExtractResult(state, (start, end), cc);

        [MethodImpl(Inline)]
        public static ApiExtractResult Define(in ApiExtractState state, MemoryRange source, ExtractTermCode cc)
            => new ApiExtractResult(state, source, cc);

        [MethodImpl(Inline)]
        ApiExtractResult(in ApiExtractState state, MemoryRange range, ExtractTermCode cc)
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