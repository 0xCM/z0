//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitSpans
    {
        public static BitSpan create<T>(T src)
            where T : unmanaged
                => gbits.unpack(src);

        public static BitSpan create<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gbits.unpack(src);

        public static BitSpan create<T>(Span<T> src)
            where T : unmanaged
                => gbits.unpack(src.ReadOnly());

        [MethodImpl(Inline), Op]
        public static BitSpan create<T>(ReadOnlySpan<T> src, Span<bit> buffer)
            where T : unmanaged
                => gbits.unpack(src, buffer);
    }
}