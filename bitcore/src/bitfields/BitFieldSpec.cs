//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

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

        [MethodImpl(Inline)]
        public BitFieldReader<T> Reader<T>()
            where T : unmanaged
                => new BitFieldReader<T>(this);

        public string Format()
            => FieldSegments.format(Segments);

        public override string ToString()
            => Format();                        
   }    
}