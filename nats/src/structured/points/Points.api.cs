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
    
    public static class Points
    {
        public static Points<N,T> alloc<N,T>(int count, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Span<Point<N,T>>(new Point<N,T>[count]);

        [MethodImpl(Inline)]
        public static Point<N1,T> point<T>(T x0)
            where T : unmanaged
                => new Point<N1, T>(x0);                 

        [MethodImpl(Inline)]
        public static Point<N2,T> point<T>(T x0, T x1)
            where T : unmanaged
                => new Point<N2,T>(x0,x1);

        [MethodImpl(Inline)]
        public static Point<N3,T> point<T>(T x0, T x1, T x2)
            where T : unmanaged
                => new Point<N3,T>(x0,x1,x2);         

        [MethodImpl(Inline)]
        public static Point<N4,T> point<T>(T x0, T x1, T x2, T x3)
            where T : unmanaged
                => new Point<N4, T>(x0,x1,x2,x3);         

        [MethodImpl(Inline)]
        public static Point<X0> singular<X0>(X0 x0)
            where X0 : unmanaged
                => new Point<X0>(x0);

        [MethodImpl(Inline)]
        public static MixedPoint<X0,X1> mixed<X0,X1>(X0 x0, X1 x1)
            where X0 : unmanaged
            where X1 : unmanaged
                => new MixedPoint<X0,X1>(x0,x1);

        [MethodImpl(Inline)]
        public static MixedPoint<X0,X1,X2> mixed<X0,X1,X2>(X0 x0, X1 x1, X2 x2)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => new MixedPoint<X0,X1, X2>(x0,x1,x2);

        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,T>(MixedPoints<X0,X1> points, T t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where T : unmanaged
                => points.Linearize<T>();

        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,X2,T>(MixedPoints<X0,X1,X2> points, T t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
            where T : unmanaged
                => points.Linearize<T>();

        [MethodImpl(Inline)]
        public static Points<MixedPoint<X0,X1>> cellularize<X0,X1>(MixedPoints<X0,X1> points)
            where X0 : unmanaged
            where X1 : unmanaged
                => points.Cellularize();

        [MethodImpl(Inline)]
        public static Points<MixedPoint<X0,X1,X2>> cellularize<X0,X1,X2>(MixedPoints<X0,X1,X2> points)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => points.Cellularize();
    }
}