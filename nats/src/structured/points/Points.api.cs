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
        public static HomPoints<N,T> homalloc<N,T>(int count, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Span<HomPoint<N,T>>(new HomPoint<N,T>[count]);

        public static Points<X0,X1> alloc<X0,X1>(int count) 
            where X0 : unmanaged
            where X1 : unmanaged
                => new Point<X0,X1>[count];

        public static Points<X0,X1,X2> alloc<X0,X1,X2>(int count) 
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => new Point<X0,X1,X2>[count];

        [MethodImpl(Inline)]
        public static HomPoint<N1,T> hom<T>(T x0)
            where T : unmanaged
                => new HomPoint<N1, T>(x0);         
        
        [MethodImpl(Inline)]
        public static HomPoint<N2,T> hom<T>(T x0, T x1)
            where T : unmanaged
                => new HomPoint<N2, T>(x0,x1);         

        [MethodImpl(Inline)]
        public static HomPoint<N3,T> hom<T>(T x0, T x1, T x2)
            where T : unmanaged
                => new HomPoint<N3, T>(x0,x1,x2);         

        [MethodImpl(Inline)]
        public static Point<X0> point<X0>(X0 x0)
            where X0 : unmanaged
                => new Point<X0>(x0);

        [MethodImpl(Inline)]
        public static Point<X0,X1> point<X0,X1>(X0 x0, X1 x1)
            where X0 : unmanaged
            where X1 : unmanaged
                => new Point<X0,X1>(x0,x1);

        [MethodImpl(Inline)]
        public static Point<X0,X1,X2> point<X0,X1,X2>(X0 x0, X1 x1, X2 x2)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => new Point<X0,X1, X2>(x0,x1,x2);


        [MethodImpl(Inline)]
        public static HomPoint<N2,X> point<X>(X x0, X x1, N2 n)
            where X : unmanaged
                => new HomPoint<N2,X>(x0,x1);

        [MethodImpl(Inline)]
        public static HomPoint<N3,X> point<X>(X x0, X x1, X x2, N3 n)
            where X : unmanaged
                => new HomPoint<N3,X>(x0,x1,x2);


        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,T>(Points<X0,X1> points, T t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where T : unmanaged
                => points.Linearize<T>();

        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,X2,T>(Points<X0,X1,X2> points, T t = default)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
            where T : unmanaged
                => points.Linearize<T>();


        [MethodImpl(Inline)]
        public static Points<Point<X0,X1>> cellularize<X0,X1>(Points<X0,X1> points)
            where X0 : unmanaged
            where X1 : unmanaged
                => points.Cellularize();

        [MethodImpl(Inline)]
        public static Points<Point<X0,X1,X2>> cellularize<X0,X1,X2>(Points<X0,X1,X2> points)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => points.Cellularize();




    }
}