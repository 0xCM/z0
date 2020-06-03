//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;    
    using static Memories;

    /// <summary>
    /// Defines a partition over a contiguous sequence of bits
    /// </summary>
    public readonly struct BitFieldSpec :  ITextual<BitFieldSpec>
    {        
        readonly FieldSegment[] segments;

        [MethodImpl(Inline)]
        internal BitFieldSpec(FieldSegment[] fields)
        {
            this.segments = fields;
        }

        [MethodImpl(Inline)]
        public ref readonly FieldSegment Segment(int index)
            => ref Segments[index];

        public ref readonly FieldSegment this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Segment(i);
        }

        public int FieldCount
        {
            [MethodImpl(Inline)]
            get => segments.Length;
        }

        /// <summary>
        /// The sum of the widths of the defining segments
        /// </summary>
        public uint TotalWidth
        {
            [MethodImpl(Inline)]
            get => BitFieldSpecs.width(this);
        }

        public ReadOnlySpan<FieldSegment> Segments 
        {
            [MethodImpl(Inline)]
            get => segments;
        }

        public string Format()
            => BitFields.format(Segments);

        public override string ToString()
            => Format();                
   }    
}