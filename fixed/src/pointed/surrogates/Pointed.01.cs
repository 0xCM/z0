//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Pointed<X0,R> : IPointedSurrogate<PointedFunc<X0,R>, Point<X0>, Point<R>>
        where X0 : unmanaged, IFixed
        where R : unmanaged, IFixed
    {
        readonly PointedFunc<X0,R> F;
        
        [MethodImpl(Inline)]
        internal Pointed(in PointedFunc<X0,R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public Point<R> Evaluate(in Point<X0> x0) => F(x0);

        public PointedFunc<X0,R> Evaluator  => F;
    }
}