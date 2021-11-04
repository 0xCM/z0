//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> deferred<T>(ISource src)
            => core.defer(stream<T>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> deferred<T>(IBoundSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => core.defer(stream<T>(src, domain, filter));
    }
}