//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void write<T>(in T src, ref byte dst)
            => WriteUnaligned(ref dst, src);

        [MethodImpl(Inline), Op]
        public static SpanWriter writer(Span<byte> src)
            => new SpanWriter(src);
    }
}