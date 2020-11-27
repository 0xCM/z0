//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Collective
    {
        [MethodImpl(Inline)]
        public static Deferred<T> defer<T>(IEnumerable<T> src)
            => new Deferred<T>(src);

        [MethodImpl(Inline)]
        public static Deferred<T> defer<T>(params T[] src)
            => new Deferred<T>(src);
    }
}
