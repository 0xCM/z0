//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct scalars
    {
        [MethodImpl(Inline)]
        public static And<T> and<T>(T a, T b)
            where T : IExpr
                => new And<T>(a,b);

        [MethodImpl(Inline)]
        public static Or or<T>(T a, T b)
            where T : IExpr
                => new Or(a,b);

        [MethodImpl(Inline)]
        public static Not not<T>(T a)
            where T : IExpr
                => new Not(a);

        [MethodImpl(Inline)]
        public static Xor xor<T>(T a, T b)
            where T : IExpr
                => new Xor(a,b);
    }
}