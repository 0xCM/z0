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
        public static Adjacent<T> adjacent<T>(T a, T b)
            => new Adjacent<T>(a, b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Adjacent<S,T> adjacent<S,T>(S a, T b)
            => new Adjacent<S,T>(a, b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Adjacent<T,OneOf<T>> adjacent<T>(T a, OneOf<T> b)
            => new Adjacent<T,OneOf<T>>(a, b);
    }
}