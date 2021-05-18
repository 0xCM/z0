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

   public readonly struct BitfieldSpec<E,W> : ITextual<BitfieldSpec<E,W>>
        where E : unmanaged
        where W : unmanaged
    {
        /// <summary>
        /// The bitfield definition upon which the reader is predicated
        /// </summary>
        readonly BitfieldSegSpecs Untyped;

        public uint TotalWidth {get;}

        public ReadOnlySpan<BitfieldPart> Segments
        {
            [MethodImpl(Inline)]
            get => Untyped.Segments;
        }

        [MethodImpl(Inline)]
        public BitfieldSpec(in BitfieldSegSpecs untyped, uint bitcount)
        {
            TotalWidth = bitcount;
            Untyped = untyped;
        }

        public string Format()
            => api.format(Segments);

        public override string ToString()
            => Format();
    }
}