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

    partial class XTend
    {
        public static string FormatBitstring(this Hex32 src, N8 n)
        {
            Span<char> buffer = stackalloc char[64];
            var count = HexVector.bitstring(src, n, 0,buffer);
            return new string(slice(buffer,0,count));
        }
    }

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

        public static HexVector8<N> alloc<N>(W8 w, N n = default)
            where N : unmanaged, ITypeNat
                => new HexVector8<N>(new Hex8[NatValues.value<N>()]);

        [MethodImpl(Inline)]
        public static HexVector8<N> create<N>(W8 w, Span<Hex8> src, N n = default, uint offset = 0)
            where N : unmanaged, ITypeNat
                => new HexVector8<N>(slice(src, offset, NatValues.value<N>()));

        [MethodImpl(Inline)]
        public static HexVector8<N> create<N>(W8 w, Span<byte> src, N n = default, uint offset = 0)
            where N : unmanaged, ITypeNat
                => new HexVector8<N>(recover<Hex8>(slice(src, offset, NatValues.value<N>())));

        /// <summary>
        /// Creates a vector with specified component count and width, initialized wtih a specified value
        /// </summary>
        /// <param name="n">The component count</param>
        /// <param name="w">The component width</param>
        /// <param name="src">The initial value</param>
        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, W8 w, uint src)
            => create(n,w,bytes(src));

        public static uint bitstring<N>(HexVector8<N> src, uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
                => BitRender.render<N>(n8,n8, src.Bytes, offset, dst);

        [Op]
        public static uint bitstring(Hex32 src, N8 n, uint offset, Span<char> dst)
            => BitRender.render(n32, n, src.Value, offset, dst);

    }
}