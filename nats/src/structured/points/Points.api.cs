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
    
    using Het = HetPoints;

    public static class Points
    {
        [MethodImpl(Inline)]
        public static HomPoint<N2,T> hom<T>(T x0, T x1)
            where T : unmanaged
                => new HomPoint<N2, T>(x0,x1);         


        [MethodImpl(Inline)]
        public static HomPoint<N3,T> hom<T>(T x0, T x1, T x2)
            where T : unmanaged
                => new HomPoint<N3, T>(x0,x1,x2);         


        [MethodImpl(Inline)]
        public static Het.Point<X0,X1> point<X0,X1>(X0 x0, X1 x1)
            where X0 : unmanaged
            where X1 : unmanaged
                => new Het.Point<X0,X1>(x0,x1);


        [MethodImpl(Inline)]
        public static Het.Point<X0,X1,X2> point<X0,X1,X2>(X0 x0, X1 x1, X2 x2)
            where X0 : unmanaged
            where X1 : unmanaged
            where X2 : unmanaged
                => new Het.Point<X0,X1, X2>(x0,x1,x2);

        
        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,T>(Points<X0,X1> points, T t = default)
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
            where T : unmanaged
                => points.Linearize<T>();

        [MethodImpl(Inline)]
        public static Span<T> lineraize<X0,X1,X2,T>(Points<X0,X1,X2> points, T t = default)
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
            where X2 : unmanaged, IPointed<X2>
            where T : unmanaged
                => points.Linearize<T>();


        [MethodImpl(Inline)]
        public static Points<Het.Point<X0,X1>> cellularize<X0,X1>(Points<X0,X1> points)
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
                => points.Cellularize();

        [MethodImpl(Inline)]
        public static Points<Het.Point<X0,X1,X2>> cellularize<X0,X1,X2>(Points<X0,X1,X2> points)
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
            where X2 : unmanaged, IPointed<X2>
                => points.Cellularize();


        [MethodImpl(Inline)]
        public static HomPoints<N,T> alloc<N,T>(int count, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Span<HomPoint<N,T>>(new HomPoint<N,T>[count]);

        public static Points<X0,X1> alloc<X0,X1>(int count) 
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
                => new Het.Point<X0,X1>[count];

        public static Points<X0,X1,X2> alloc<X0,X1,X2>(int count) 
            where X0 : unmanaged, IPointed<X0>
            where X1 : unmanaged, IPointed<X1>
            where X2 : unmanaged, IPointed<X2>
                => new Het.Point<X0,X1,X2>[count];

    }
}