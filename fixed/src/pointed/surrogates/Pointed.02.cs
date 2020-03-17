//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Pointed<X0,X1,R> : IPointedSurrogate<PointedFunc<X0,X1,R>, MixedPoint<X0,X1>, Point<R>>
        where X0 : unmanaged, IFixed
        where X1 : unmanaged, IFixed
        where R : unmanaged, IFixed
    {

        readonly PointedFunc<X0,X1,R> F;
       

        [MethodImpl(Inline)]
        public static implicit operator PointedFunc<X0,X1,R>(Pointed<X0,X1,R> src)
            => src.F;

        [MethodImpl(Inline)]
        internal Pointed(in PointedFunc<X0,X1,R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public Point<R> Evaluate(in MixedPoint<X0,X1> x0) => F(x0);

        public PointedFunc<X0,X1,R> Evaluator  => F;
    }
}