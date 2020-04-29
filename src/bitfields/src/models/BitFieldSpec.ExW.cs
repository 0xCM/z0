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

   public readonly struct BitFieldSpec<E,W> : IFormattable<BitFieldSpec<E,W>>
        where E : unmanaged, Enum
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