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
    public readonly struct HexVector
    {
        public static uint bitstring<N>(HexVector8<N> src, uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
                => BitRender.render8x8<N>(src.Bytes, offset, dst);
        [Op]
        public static uint bitstring(Hex32 src, N8 n, uint offset, Span<char> dst)
            => BitRender.render32x8(src.Value, offset, dst);

        [MethodImpl(Inline), Op]
        public static HexVector4 v4(byte[] src)
            => new HexVector4(src);

        [MethodImpl(Inline), Op]
        public static HexVector8 v8(Hex8[] src)
            => new HexVector8(src);

        [MethodImpl(Inline), Op]
        public static HexVector16 v16(Hex16[] src)
            => new HexVector16(src);

        [MethodImpl(Inline), Op]
        public static HexVector32 v32(Hex32[] src)
            => new HexVector32(src);
    }
}