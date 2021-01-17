//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fenced<T> enclose<T>(Index<T> content, T left, T right)
            => new Fenced<T>(content, fence(left, right));

        [MethodImpl(Inline)]
        public static Fenced<C,F> enclose<C,F>(C content, Fence<F> fence)
            => new Fenced<C, F>(content, fence);

        [MethodImpl(Inline)]
        public static Fenced<C,F> enclose<C,F>(C content, F left, F right)
            => new Fenced<C,F>(content, fence(left, right));
    }
}