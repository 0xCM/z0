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
        public static Bijection<T> bijection<T>(Index<T> src, Index<T> dst)
            => new Bijection<T>(src, dst);

        [MethodImpl(Inline)]
        public static Bijection<S,T> bijection<S,T>(Index<S> src, Index<T> dst)
            => new Bijection<S,T>(src, dst);
    }
}