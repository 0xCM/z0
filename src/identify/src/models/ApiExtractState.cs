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
    /// Defines the state of the routine capture workflow at a given step
    /// </summary>
    public readonly struct ApiExtractState : IFormattable<ApiExtractState>
    {
        /// <summary>
        /// The empty state
        /// </summary>
        public static ApiExtractState Empty => new ApiExtractState(OpIdentity.Empty, 0,0,0);

        /// <summary>
        /// The subject identifier
        /// </summary>
        public readonly OpIdentity OpId;

        /// <summary>
        /// The zero-based and monotonically-increasing state index
        /// </summary>
        public readonly int Offset;

        /// <summary>
        /// The memory address from which the state payload was extracted
        /// </summary>
        public readonly MemoryAddress Location;

        /// <summary>
        /// The captured data
        /// </summary>
        public readonly byte Extracted;

        /// <summary>
        /// Defines a capture state
        /// </summary>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="extracted">The extracted data</param>
        [MethodImpl(Inline)]
        public static ApiExtractState Define(OpIdentity opid, int offset, long location, byte extracted)
            => new ApiExtractState(opid,offset,location,extracted);

        /// <summary>
        /// Defines a capture state
        /// </summary>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="extracted">The extracted data</param>
        [MethodImpl(Inline)]
        public static ApiExtractState Define(OpIdentity opid, int offset, MemoryAddress location, byte extracted)
            => new ApiExtractState(opid,offset,location,extracted);

        [MethodImpl(Inline)]
        ApiExtractState(OpIdentity opid, int offset, long location, byte extracted)
        {
            this.OpId = opid;
            this.Offset = offset - 1;
            this.Location = MemoryAddress.Define((ulong)location - 1ul);
            this.Extracted = extracted;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Offset == 0 && Location == 0 && Extracted == 0;
        }

        public string Format()
            => text.concat(OpId.ToString(), text.space(), Offset.FormatAsmHex(4), text.space(), Location.Format(), text.space(), Extracted.FormatHex());

        public override string ToString() 
            => Format();
    }
}