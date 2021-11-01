//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    using static core;

    partial struct Sources
    {
        [Op, Closures(Closure)]
        public static Span<T> polyspan<T>(IRangeSource src, int length, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var dst = span<T>(length);
            src.Fill(domain, length, ref first(dst), filter);
            return dst;
        }
    }
}