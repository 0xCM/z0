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

    partial struct z
    {
        [MethodImpl(Inline)]
        public static void iter<T>(IEnumerable<T> src, Action<T> action, bool pll = false)
            => corefunc.iter(src, action, pll);

        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> src, Action<T> action)
            => corefunc.iter(src, action);

        [MethodImpl(Inline)]
        public static void iter<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Action<S,T> f)
            => corefunc.iter(a, b, f);

        [MethodImpl(Inline)]
        public static void iter<S,T>(Span<S> a, Span<T> b, Action<S,T> f)
            => corefunc.iter(a, b, f);
    }
}