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

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in ResIdentity<byte> id)
            => MemView.view<byte>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> view(in ResIdentity<char> id)
            => MemView.view<char>(id.Address, id.CellCount);

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> view(in ResIdentity<char> res, int i0, int i1)
            => z.segment((char*)res.Address, i0, i1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in ResIdentity<byte> res, int i0, int i1)
            => MemView.view<byte>(res.Address, (i1 - i0 + 1));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> view(in StringResourceRow src)
            => MemView.view<char>(src.Address, src.Length);
    }
}