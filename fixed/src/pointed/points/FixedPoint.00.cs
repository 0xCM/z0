//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FixedPoint<X0> : IFixedPoint<X0>
        where X0 : unmanaged,IFixed
    {
        public Point<X0> Point {get;}

        [MethodImpl(Inline)]
        public static implicit operator Point<X0>(FixedPoint<X0> f)
            => f.Point;
        
        [MethodImpl(Inline)]
        public static implicit operator FixedPoint<X0>(Point<X0> p)
            => new FixedPoint<X0>(p);

        [MethodImpl(Inline)]
        public FixedPoint(Point<X0> p)
            => this.Point = p;        
    }
}