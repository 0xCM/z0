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
    /// Defines a partition over a contiguous sequence of bits
    /// </summary>
    public readonly struct BitFieldSpec :  ITextual
    {
        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            for(byte i=0; i<spec.Segments.Length; i++)
                total += spec.Segment(i).Width;
            return total;
        }

        readonly BitFieldSegment[] Data;

        [MethodImpl(Inline)]
        public BitFieldSpec(BitFieldSegment[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(int index)
            => ref Segments[index];

        public ref readonly BitFieldSegment this[int i]
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
            get => width(this);
        }

        public ReadOnlySpan<BitFieldSegment> Segments
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public string Format()
            => BitFields.format(Segments);

        public override string ToString()
            => Format();
   }
}