//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lazy<T> defer<T>(Func<T> factory)
            => new Lazy<T>(factory);

        [MethodImpl(Inline)]
        public static Deferred<T> defer<T>(IEnumerable<T> src)
            => new Deferred<T>(src);

        [MethodImpl(Inline)]
        public static Deferred<T> defer<T>(params T[] src)
            => new Deferred<T>(src);
    }
}