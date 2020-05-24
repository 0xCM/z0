//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    partial class Spans
    {
        [Op, Closures(UnsignedInts)]   
        public static ISet<T> set<T>(ReadOnlySpan<T> src)
        {
            var dst = new HashSet<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst.Add(src[i]);
            return dst;
        }

        [Op, Closures(UnsignedInts)]   
        public static ISet<T> set<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
        {
            var dst = new HashSet<T>(a.Length + b.Length);
            for(var i=0; i<a.Length; i++)
                dst.Add(a[i]);
            for(var i=0; i<b.Length; i++)
                dst.Add(b[i]);
            return dst;     
        }
    }
}