//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.BitFieldParts, true)]
    public readonly partial struct BitFieldParts
    {
        [MethodImpl(Inline), Op]
        public static BitFieldPart part(uint lsb, uint msb)
            => new BitFieldPart(lsb,msb);

        [MethodImpl(Inline), Op]
        public static BitFieldPart part(ulong data)
            => new BitFieldPart(data);

        [MethodImpl(Inline), Op]
        public static BitFieldLayout layout(params BitFieldPart[] parts)
            => new BitFieldLayout(parts);

        [MethodImpl(Inline), Op]
        public static RuntimeLayout runtime(BitFieldLayout src)
            => new RuntimeLayout(src.Storage);
    }
}