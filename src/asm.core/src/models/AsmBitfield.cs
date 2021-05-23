//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct AsmBitfield
    {
        public byte FieldCount {get;}

        public ReadOnlySpan<byte> Widths {get;}

        [MethodImpl(Inline)]
        public AsmBitfield(ReadOnlySpan<byte> widths)
        {
            FieldCount = (byte)widths.Length;
            Widths = widths;
        }
    }
}