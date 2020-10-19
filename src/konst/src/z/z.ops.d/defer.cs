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
        [MethodImpl(Inline)]
        public static Lazy<T> defer<T>(Func<T> factory)
            => new Lazy<T>(factory);

        [MethodImpl(Inline)]
        public static Source<T> defer<T>(IEnumerable<T> src)
            => new Source<T>(src);

        [MethodImpl(Inline)]
        public static Source<T> defer<T>(params T[] src)
            => new Source<T>(src);
    }
}