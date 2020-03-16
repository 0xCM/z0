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

    public readonly struct EmptyPoint : IPoint {}

    public readonly struct EmptyPoint<T> : IPoint
    {

    }

    public readonly struct Point<X0> : IPoint<X0>,  IPointCell<Point<X0>>
    {
        public readonly X0 x0;

        [MethodImpl(Inline)]
        internal Point(X0 x0)
        {
            this.x0 = x0;
        }

        public string Format()
            => text.parenthetical(x0);

        public override string ToString()
            => Format();
    }

    public readonly struct Point<X0,X1> : IPoint<X0,X1>, IPointCell<Point<X0,X1>>
    {
        public readonly X0 x0;

        public readonly X1 x1;


        [MethodImpl(Inline)]
        internal Point(X0 x0, X1 x1)
        {
            this.x0 = x0;
            this.x1 = x1;
        }

        public string Format()
            => text.parenthetical(text.comma(), x0,x1);

        public override string ToString()
            => Format();
    }    

    public readonly struct Point<X0,X1,X2> : IPoint<X0,X0,X2>,  IPointCell<Point<X0,X1,X2>>
    {
        public readonly X0 x0;

        public readonly X1 x1;

        public readonly X2 x2;


        [MethodImpl(Inline)]
        internal Point(X0 x0, X1 x1, X2 x2)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
        }

        public string Format()
            => text.parenthetical(text.comma(), x0,x1,x2);

        public override string ToString()
            => Format();

    }    

}