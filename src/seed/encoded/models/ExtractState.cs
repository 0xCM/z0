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
    public readonly struct ExtractState : ITextual, IAddressable64, IIdentified<OpIdentity>
    {
        /// <summary>
        /// The operation identifier
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The memory address from which the state payload was extracted
        /// </summary>
        public MemoryAddress Address {get;}

        /// <summary>
        /// The zero-based and monotonically-increasing state index
        /// </summary>
        public readonly int Offset;

        /// <summary>
        /// The captured data
        /// </summary>
        public readonly byte Captured;

        /// <summary>
        /// Initializes a capture state
        /// </summary>
        /// <param name="id">The exraction subject identifier</param>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="captured">The extracted data</param>
        [MethodImpl(Inline)]
        public ExtractState(OpIdentity opid, int offset, long location, byte captured)
        {
            Id = opid;
            Offset = offset - 1;
            Address = Addresses.address((ulong)location - 1ul);
            Captured = captured;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Offset == 0 && Address == 0 && Captured == 0;
        }

        public string Format()
            => text.concat(Id.ToString(), text.space(), Offset.FormatAsmHex(4), text.space(), Address.Format(), text.space(), Captured.FormatHex());

        public override string ToString() 
            => Format();

        /// <summary>
        /// The empty state
        /// </summary>
        public static ExtractState Empty 
            => new ExtractState(OpIdentity.Empty, 0,0,0);
    }
}