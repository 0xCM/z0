//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static class Polynomial
    {
        [MethodImpl(Inline)]
        public static Polynomial<T> Define<T>(params (T scalar, uint exp)[] terms)
            where T : unmanaged
                => Polynomial<T>.create(terms);
    }
}