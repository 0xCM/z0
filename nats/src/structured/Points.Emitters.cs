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

    public static class PointSpanEmitters
    {
        public static PointSpanEmitter<X0,X1,R> LoadEmitter<X0,X1,R>(this IEnumerable<Het.Point<X0,X1,R>> src)
            where X0 : unmanaged
            where X1 : unmanaged
            where R : unmanaged
                => src.ToArray();

        public static HomPointSpanEmitter<N,T> LoadEmitter<N,T>(this IEnumerable<HomPoint<N,T>> src, N n = default)
            where T : unmanaged
            where N : unmanaged,ITypeNat
                => src.ToArray();

    }

   public readonly struct HomPointSpanEmitter<N,T> : ISpanEmitter<HomPoint<N,T>>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly HomPoint<N,T>[] cases;
        
        public OpIdentity Id {get;}

        [MethodImpl(Inline)]
        public static implicit operator HomPointSpanEmitter<N,T>(HomPoint<N,T>[] src)
            => new HomPointSpanEmitter<N,T>(src);

        [MethodImpl(Inline)]
        public HomPointSpanEmitter(HomPoint<N,T>[] cases)
        {
            this.cases = cases;
        }

        [MethodImpl(Inline)]
        public Span<HomPoint<N,T>> Invoke()
            => cases;
    }


   public readonly struct PointSpanEmitter<X0, X1, R> : ISpanEmitter<Het.Point<X0, X1, R>>
        where X0 : unmanaged
        where X1 : unmanaged
        where R : unmanaged
    {
        readonly Het.Point<X0,X1,R>[] cases;
        
        public OpIdentity Id {get;}

        [MethodImpl(Inline)]
        public static implicit operator PointSpanEmitter<X0,X1,R>(Het.Point<X0,X1,R>[] src)
            => new PointSpanEmitter<X0,X1,R>(src);

        [MethodImpl(Inline)]
        public PointSpanEmitter(Het.Point<X0,X1,R>[] cases)
        {
            this.cases = cases;
        }

        [MethodImpl(Inline)]
        public Span<Het.Point<X0, X1, R>> Invoke()
            => cases;
    }
}