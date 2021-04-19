//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly ref struct AsmBitfield
    {
        public ReadOnlySpan<byte> Indices {get;}

        public ReadOnlySpan<byte> Widths {get;}

        public byte FieldCount {get;}

        [MethodImpl(Inline)]
        public AsmBitfield(ReadOnlySpan<byte> ix, ReadOnlySpan<byte> w)
        {
            Indices = ix;
            Widths = w;
            FieldCount = (byte)root.min(ix.Length, w.Length);
        }
    }
}