//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public static class Pointery
    {
        [MethodImpl(Inline)]
        public static Pointed<X0,R> surrogate<X0,R>(PointedFunc<X0,R> f)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => new Pointed<X0,R>(f);

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,R> surrogate<X0,X1,R>(PointedFunc<X0,X1,R> f)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => new Pointed<X0,X1,R>(f);

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,X2,R> surrogate<X0,X1,X2,R>(PointedFunc<X0,X1,X2,R> f)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => new Pointed<X0,X1,X2,R>(f);

        [MethodImpl(Inline)]
        public static PointedFunc<X0,R> pointed<X0,R>(Func<X0,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
                => (in Point<X0> x) => Points.singular(f(x.x0));

        [MethodImpl(Inline)]
        public static PointedFunc<X0,X1,R> pointed<X0,X1,R>(Func<X0,X1,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
                => (in MixedPoint<X0,X1> x) => Points.singular(f(x.x0,x.x1));

        [MethodImpl(Inline)]
        public static PointedFunc<X0,X1,X2,R> pointed<X0,X1,X2,R>(Func<X0,X1,X2,R> f)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (in MixedPoint<X0,X1,X2> x) => Points.singular(f(x.x0,x.x1,x.x2));

        [MethodImpl(Inline)]
        public static Pointed<X0,R> surrogate<X0,R>(Func<X0,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
                => surrogate(pointed(f));

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,R> surrogate<X0,X1,R>(Func<X0,X1,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
                => surrogate(pointed(f));

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,X2,R> surrogate<X0,X1,X2,R>(Func<X0,X1,X2,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
                => surrogate(pointed(f));
    }
}