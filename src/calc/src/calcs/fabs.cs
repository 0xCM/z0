//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Abs, Closures(Floats)]
        public static Span<T> fabs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref var a = ref first(dst);
            ref readonly var b = ref first(src);
            for(var i =0; i<count; i++)
                seek(a, i) = gfp.abs(skip(b, i));
            return dst;
        }
    }
}