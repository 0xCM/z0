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
    /// Defines the state of the routine capture workflow at a given step
    /// </summary>
    public readonly struct ExtractState
    {
        /// <summary>
        /// The memory address from which the state payload was extracted
        /// </summary>
        public readonly MemoryAddress Address;

        /// <summary>
        /// The zero-based and monotonically-increasing state index
        /// </summary>
        public readonly uint Index;

        /// <summary>
        /// The captured data
        /// </summary>
        public readonly byte Captured;

        /// <summary>
        /// The extraction termination code, if any
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// Initializes a capture state
        /// </summary>
        /// <param name="id">The exraction subject identifier</param>
        /// <param name="index">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="captured">The extracted data</param>
        [MethodImpl(Inline)]
        public ExtractState(uint index, long location, byte captured, ExtractTermCode term = default)
        {
            Index = index - 1u;
            Address = z.address((ulong)location - 1ul);
            Captured = captured;
            TermCode = term;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0 && Address == 0 && Captured == 0;
        }

        public string Format()
            => text.concat(Index.FormatAsmHex(4), Space, Address.Format(), Space, Captured.FormatHex());

        public override string ToString() 
            => Format();

        /// <summary>
        /// The empty state
        /// </summary>
        public static ExtractState Empty 
            => default;
    }
}