//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    /// <summary>
    /// Defines a partition over a contiguous sequence of bits
    /// </summary>
    public readonly struct BitFieldSpec :  IFormattable<BitFieldSpec>
    {        
        readonly FieldSegment[] segments;

        [MethodImpl(Inline)]
        internal BitFieldSpec(FieldSegment[] fields)
        {
            this.segments = fields;
        }

        [MethodImpl(Inline)]
        public ref readonly FieldSegment Segment(byte index)
            => ref Segments[index];

        public ref readonly FieldSegment this[byte i]
        {
            [MethodImpl(Inline)]
            get => ref Segment(i);
        }

        public byte FieldCount
        {
            [MethodImpl(Inline)]
            get => (byte)segments.Length;
        }

        /// <summary>
        /// The sum of the widths of the defining segments
        /// </summary>
        public byte TotalWidth
        {
            [MethodImpl(Inline)]
            get => BitField.width(this);
        }

        public ReadOnlySpan<FieldSegment> Segments 
        {
            [MethodImpl(Inline)]
            get => segments;
        }

        public string Format()
            => FieldSegments.format(Segments);

        public override string ToString()
            => Format();                
   }    

    public readonly struct BitFieldSpec<I, W> : IFormattable<BitFieldSpec<I,W>>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        readonly BitFieldSpec Untyped;

        public int TotalWidth {get;}

        public ReadOnlySpan<FieldSegment> Segments 
        {
            [MethodImpl(Inline)]
            get => Untyped.Segments;
        }

        [MethodImpl(Inline)]
        internal BitFieldSpec(in BitFieldSpec untyped, int bitcount)
        {
            this.TotalWidth = bitcount;
            this.Untyped = untyped;
        }        

        public string Format()
            => FieldSegments.format(Segments);

        public override string ToString()
            => Format();                
    }
}