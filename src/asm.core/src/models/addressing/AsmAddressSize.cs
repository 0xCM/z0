//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct AsmAddressSize
    {
        public byte Width {get;}

        [MethodImpl(Inline)]
        public AsmAddressSize(uint2 index)
        {
            Width = skip(Widths, index);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmAddressSize(byte index)
            => new AsmAddressSize(index);

        static ReadOnlySpan<byte> Widths => new byte[3]{16,32,64};
    }
}