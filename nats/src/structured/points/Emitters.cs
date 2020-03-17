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

   public readonly struct PointSpanEmitter<N,T> : ISpanEmitter<Point<N,T>>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly Point<N,T>[] cases;
        
        public OpIdentity Id {get;}

        [MethodImpl(Inline)]
        public static implicit operator PointSpanEmitter<N,T>(Point<N,T>[] src)
            => new PointSpanEmitter<N,T>(src);


        [MethodImpl(Inline)]
        public PointSpanEmitter(Point<N,T>[] cases)
        {
            this.cases = cases;
        }

        [MethodImpl(Inline)]
        public Span<Point<N,T>> Invoke()
            => cases;
    }

   public readonly struct MixedPointSpanEmitter<X0, X1, R> : ISpanEmitter<MixedPoint<X0, X1, R>>
        where X0 : unmanaged
        where X1 : unmanaged
        where R : unmanaged
    {
        readonly MixedPoint<X0,X1,R>[] cases;
        
        public OpIdentity Id {get;}

        [MethodImpl(Inline)]
        public static implicit operator MixedPointSpanEmitter<X0,X1,R>(MixedPoint<X0,X1,R>[] src)
            => new MixedPointSpanEmitter<X0,X1,R>(src);

        [MethodImpl(Inline)]
        public MixedPointSpanEmitter(MixedPoint<X0,X1,R>[] cases)
        {
            this.cases = cases;
        }

        [MethodImpl(Inline)]
        public Span<MixedPoint<X0, X1, R>> Invoke()
            => cases;
    }
}