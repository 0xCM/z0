//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct AsmBitfields
    {
        [MethodImpl(Inline), Op]
        public static BitfieldFormatter formatter(AsmBitfield src)
            => new BitfieldFormatter(src);

        [MethodImpl(Inline), Op]
        public static AsmBitfield define(ReadOnlySpan<byte> ix, ReadOnlySpan<byte> w)
            => new AsmBitfield(ix,w);

        [MethodImpl(Inline), Op]
        public static AsmBitfield modrm()
            => define(ModRmIndices,ModRmWidths);

        static ReadOnlySpan<byte> ModRmIndices => new byte[3]{0,3,5};

        static ReadOnlySpan<byte> ModRmWidths => new byte[3]{3,3,2};
    }
}