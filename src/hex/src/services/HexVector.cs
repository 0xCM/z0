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
        public static uint bitstring<N>(HexVector8<N> src, uint i, Span<char> dst)
            where N : unmanaged, ITypeNat
                => BitRender.render8x8<N>(src.Bytes, i, dst);
        [Op]
        public static uint bitstring(Hex32 src, N8 n, Span<char> dst)
        {
            var i = 0u;
            return BitRender.render32x8(src.Value, ref i, dst);
        }
    }
}