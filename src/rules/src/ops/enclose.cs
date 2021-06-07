//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fenced<T> fenced<T>(DelimitedIndex<T> content, T left, T right)
            => new Fenced<T>(content, fence(left, right));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fenced<T> fenced<T>(DelimitedIndex<T> content, Pair<T> pair)
            => new Fenced<T>(content, fence(pair.Left, pair.Right));

        [MethodImpl(Inline)]
        public static Fenced<C,F> fenced<C,F>(C content, Fence<F> fence)
            => new Fenced<C,F>(content, fence);

        [MethodImpl(Inline)]
        public static Fenced<C,F> fenced<C,F>(C content, Pair<F> pair)
            => fenced(content, fence(pair.Left, pair.Right));

        [MethodImpl(Inline)]
        public static Fenced<C,F> fenced<C,F>(C content, F left, F right)
            => new Fenced<C,F>(content, fence(left, right));
    }
}