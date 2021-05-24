//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = BitfieldSpecs;

    /// <summary>
    /// Defines a partition over a contiguous sequence of bits
    /// </summary>
    public readonly struct BitfieldParts :  ITextual
    {
        readonly Index<BitfieldPart> Data;

        [MethodImpl(Inline)]
        public BitfieldParts(BitfieldPart[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly BitfieldPart Segment(int index)
            => ref Segments[index];

        public ref readonly BitfieldPart this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Segment(i);
        }

        public int FieldCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        /// <summary>
        /// The sum of the widths of the defining segments
        /// </summary>
        public uint TotalWidth
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        public ReadOnlySpan<BitfieldPart> Segments
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => api.format(Segments);

        public override string ToString()
            => Format();
   }
}