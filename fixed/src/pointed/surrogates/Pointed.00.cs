//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Pointed<R> : IPointedSurrogate<PointedFunc<R>, Point<R>>
        where R : unmanaged,IFixed
    {
        readonly PointedFunc<R> F;
        
        [MethodImpl(Inline)]
        public static implicit operator PointedFunc<R>(Pointed<R> src)
            => src.F;

        [MethodImpl(Inline)]
        internal Pointed(PointedFunc<R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public Point<R> Evaluate() => F();

        public PointedFunc<R> Evaluator => Evaluate;
    }
}