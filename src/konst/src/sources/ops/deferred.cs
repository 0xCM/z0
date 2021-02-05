//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> deferred<T>(IDataSource src)
            => root.defer(stream<T>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> deferred<T>(IDomainSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => root.defer(stream<T>(src, domain, filter));
    }
}