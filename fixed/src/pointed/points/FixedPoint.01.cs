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

    public readonly struct FixedPoint<X0,X1> : IFixedPoint<X0,X1>
        where X0 : unmanaged,IFixed
        where X1 : unmanaged, IFixed
    {
        public Point<X0,X1> Point {get;}

        [MethodImpl(Inline)]
        public static implicit operator Point<X0,X1>(FixedPoint<X0,X1> f)
            => f.Point;
        
        [MethodImpl(Inline)]
        public static implicit operator FixedPoint<X0,X1>(Point<X0,X1> p)
            => new FixedPoint<X0,X1>(p);

        [MethodImpl(Inline)]
        public FixedPoint(Point<X0,X1> p)
            => this.Point = p;    
    }
}