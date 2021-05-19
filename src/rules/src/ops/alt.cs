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
        public static Alt<T> alt<T>(T a, T b)
            => new Alt<T>(a,b);

        [MethodImpl(Inline)]
        public static Alt<A,B> alt<A,B>(A a, B b)
            => new Alt<A,B>(a,b);
    }
}