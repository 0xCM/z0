//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = BitFields;

    /// <summary>
    /// Defines a partition over a contiguous sequence of bits
    /// </summary>
    public readonly struct BitFieldSpec :  ITextual
    {
        readonly Index<BitSegment> Data;

        [MethodImpl(Inline)]
        public BitFieldSpec(BitSegment[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly BitSegment Segment(int index)
            => ref Segments[index];

        public ref readonly BitSegment this[int i]
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

        public ReadOnlySpan<BitSegment> Segments
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