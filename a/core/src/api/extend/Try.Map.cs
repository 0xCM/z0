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

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Y? TryMap<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : (Y?)null;

        [MethodImpl(Inline)]
        public static S? TryMapValue<T, S>(this T? x, Func<T, S> f)
            where T : struct
            where S : struct
                => x != null ? f(x.Value) : (S?)null;
    }
}