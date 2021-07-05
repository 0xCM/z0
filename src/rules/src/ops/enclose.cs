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
        public static Enclosed<T> enclose<T>(DelimitedIndex<T> content, T left, T right)
            => new Enclosed<T>(content, fence(left, right));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Enclosed<T> enclose<T>(DelimitedIndex<T> content, Pair<T> pair)
            => new Enclosed<T>(content, fence(pair.Left, pair.Right));

        [MethodImpl(Inline)]
        public static Enclosed<C,F> enclose<C,F>(C content, Fence<F> fence)
            => new Enclosed<C,F>(content, fence);

        [MethodImpl(Inline)]
        public static Enclosed<C,F> enclose<C,F>(C content, Pair<F> pair)
            => enclose(content, fence(pair.Left, pair.Right));

        [MethodImpl(Inline)]
        public static Enclosed<C,F> enclose<C,F>(C content, F left, F right)
            => new Enclosed<C,F>(content, fence(left, right));
    }
}