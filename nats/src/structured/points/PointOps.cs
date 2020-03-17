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

    public static class PointOps
    {
        [MethodImpl(Inline)]
        public static Points<P> Index<P>(this Span<P> src)
            where P : unmanaged, IPointCell<P>
                => src;

        [MethodImpl(Inline)]
        public static Points<P> Index<P>(this P[] src)
            where P : unmanaged, IPointCell<P>
                => src;

        [MethodImpl(Inline)]
        public static Points<P> Index<P>(this IEnumerable<P> src)
            where P : unmanaged, IPointCell<P>
                => src.ToArray();

        [MethodImpl(Inline)]
        public static Points<N,T> Index<N,T>(this Span<Point<N,T>> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src;

        public static MixedPointSpanEmitter<X0,X1,R> Emitter<X0,X1,R>(this IEnumerable<MixedPoint<X0,X1,R>> src)
            where X0 : unmanaged
            where X1 : unmanaged
            where R : unmanaged
                => src.ToArray();

        public static PointSpanEmitter<N,T> Emitter<N,T>(this IEnumerable<Point<N,T>> src, N n = default)
            where T : unmanaged
            where N : unmanaged,ITypeNat
                => src.ToArray();
    }
}