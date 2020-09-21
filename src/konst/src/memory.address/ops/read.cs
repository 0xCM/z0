//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Address
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> read(in ResIdentity<char> res, int i0, int i1)
            => z.segment((char*)res.Address, i0, i1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> read(in ResIdentity<byte> res, int i0, int i1)
            => view<byte>(res.Address, (i1 - i0 + 1));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> read(in ResIdentity<byte> id)
            => view<byte>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> read(in ResIdentity<char> id)
            => view<char>(id.Address, id.CellCount);

        const int ResLength = 0xA;

    }
}