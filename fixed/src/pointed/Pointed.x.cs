//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;


    public static class PointedExtensions
    {
        [MethodImpl(Inline)]
        public static Pointed<R> Surrogate<R>(this PointedFunc<R> f)
            where R : unmanaged, IFixed
                => Pointery.surrogate(f);

        [MethodImpl(Inline)]
        public static Pointed<X0,R> Surrogate<X0,R>(this PointedFunc<X0,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
                => Pointery.surrogate(f);

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,R> Surrogate<X0,X1,R>(this PointedFunc<X0,X1,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
                => Pointery.surrogate(f);

        [MethodImpl(Inline)]
        public static Pointed<X0,X1,X2,R> Surrogate<X0,X1,X2,R>(this PointedFunc<X0,X1,X2,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
                => Pointery.surrogate(f);

        [MethodImpl(Inline)]
        public static PointedFunc<R> Pointed<R>(this Func<R> f)
            where R : unmanaged, IFixed
                => Pointery.pointed(f);

        [MethodImpl(Inline)]
        public static PointedFunc<X0,R> ToPointed<X0,R>(this Func<X0,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
                => Pointery.pointed(f);

        [MethodImpl(Inline)]
        public static PointedFunc<X0,X1,R> Pointed<X0,X1,R>(this Func<X0,X1,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
                => Pointery.pointed(f);

        [MethodImpl(Inline)]
        public static PointedFunc<X0,X1,X2,R> Pointed<X0,X1,X2,R>(this Func<X0,X1,X2,R> f)
            where R : unmanaged, IFixed
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
                => Pointery.pointed(f);


        [MethodImpl(Inline)]
        public static FixedPoint<X0> Fixed<X0>(this Point<X0> p)
            where X0 : unmanaged, IFixed
                => p;

        [MethodImpl(Inline)]
        public static FixedPoint<X0,X1> Fixed<X0,X1>(this Point<X0,X1> p)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
                => p;

        [MethodImpl(Inline)]
        public static FixedPoint<X0,X1,X2> Fixed<X0,X1,X2>(this Point<X0,X1,X2> p)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
                => p;

    }
}