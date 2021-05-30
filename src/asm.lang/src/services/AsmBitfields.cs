//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct AsmBitfields
    {
        [MethodImpl(Inline), Op]
        public static AsmFieldFormatter formatter(AsmBitfield src)
            => new AsmFieldFormatter(src);

        [MethodImpl(Inline), Op]
        public static AsmBitfield define(ReadOnlySpan<byte> widths)
            => new AsmBitfield(widths);

        [MethodImpl(Inline), Op]
        public static AsmBitfield modrm()
            => define(ModRmWidths);

        static ReadOnlySpan<byte> ModRmWidths => new byte[3]{3,3,2};
    }
}