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
        public static Span<T> map<S,T>(ReadOnlySpan<S> src, Func<S,T> f, Span<T> dst)
            => corefunc.map(src,f,dst);

        [MethodImpl(Inline)]
        public static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
            => corefunc.map(src,f);

        [MethodImpl(Inline)]
        public static Span<R> map<S,T,R>(ReadOnlySpan<S> x, ReadOnlySpan<T> y, Func<S,T,R> f, Span<R> dst)
            => corefunc.map(x,y,f,dst);

        [MethodImpl(Inline)]
        public static Span<R> map<S,T,R>(ReadOnlySpan<S> x, ReadOnlySpan<T> y, Func<S,T,R> f)
            => corefunc.map(x, y, f);
    }
}