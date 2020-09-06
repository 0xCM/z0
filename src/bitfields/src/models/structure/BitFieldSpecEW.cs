//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

   public readonly struct BitFieldSpec<E,W> : ITextual<BitFieldSpec<E,W>>
        where E : unmanaged, Enum
        where W : unmanaged, Enum
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        readonly BitFieldSpec Untyped;

        public uint TotalWidth {get;}

        public ReadOnlySpan<BitFieldSegment> Segments
        {
            [MethodImpl(Inline)]
            get => Untyped.Segments;
        }

        [MethodImpl(Inline)]
        internal BitFieldSpec(in BitFieldSpec untyped, uint bitcount)
        {
            TotalWidth = bitcount;
            Untyped = untyped;
        }

        public string Format()
            => BitFields.format(Segments);

        public override string ToString()
            => Format();
    }
}