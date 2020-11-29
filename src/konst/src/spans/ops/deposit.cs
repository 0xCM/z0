//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial class Spans
    {
        [MethodImpl(Inline), Closures(Closure)]
        public static void deposit<T>(ReadOnlySpan<T> src, HashSet<T> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst.Add(skip(src,i));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, HashSet<T> dst)
        {
            var kA = a.Length;
            for(var i=0; i<kA; i++)
                dst.Add(skip(a,i));

            var kB = b.Length;
            for(var i=0; i<kB; i++)
                dst.Add(skip(b,i));
        }
    }
}