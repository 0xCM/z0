//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    [ApiHost]
    public readonly struct HexVector
    {
        [MethodImpl(Inline), Op]
        public static HexVector8 create(Span<Hex8> src)
            => src;

        [MethodImpl(Inline), Op]
        public static HexVector8<N4> segment(in HexVector8 src, uint offset, N4 n)
            => create(n, w8, src.Slice(offset, n).Bytes);

        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, W8 w, Span<byte> src)
            => new HexVector8<N4>(recover<Hex8>(src));

        [MethodImpl(Inline), Op]
        public static HexVector16<N4> create(N4 n, W16 w, Span<byte> src)
            => new HexVector16<N4>(recover<Hex16>(src));

        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, N8 w)
            => new HexVector8<N4>(recover<Hex8>(Cells.alloc(n32).Bytes));

        [MethodImpl(Inline), Op]
        public static HexVector16<N4> create(N4 n, W16 w)
            => create(n, w, bytes(0u));

        /// <summary>
        /// Creates a vector with specified component count and width, initialized wtih a specified value
        /// </summary>
        /// <param name="n">The component count</param>
        /// <param name="w">The component width</param>
        /// <param name="src">The initial value</param>
        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, W8 w, uint src)
            => create(n,w,bytes(src));
    }
}