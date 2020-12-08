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
        public static void iter<T>(IEnumerable<T> src, Action<T> action, bool pll = false)
            => zfunc.iter(src, action, pll);

        // [MethodImpl(Inline)]
        // public static void iter<T>(T[] src, Action<T> action)
        //     => zfunc.iter(src,action);

        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> src, Action<T> action)
            => zfunc.iter(src, action);

        [MethodImpl(Inline)]
        public static void iter<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Action<S,T> f)
            => zfunc.iter(a, b, f);

        [MethodImpl(Inline)]
        public static void iter<S,T>(Span<S> a, Span<T> b, Action<S,T> f)
            => zfunc.iter(a, b, f);
    }
}