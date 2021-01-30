//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public readonly struct Region : IRule<Region>
        {
            public dynamic Base {get;}

            public Pair<dynamic> UpperLeft {get;}

            public Pair<dynamic> LowerRight {get;}

            [MethodImpl(Inline)]
            public Region(dynamic @base, Pair<dynamic> tl, Pair<dynamic> br)
            {
                Base = @base;
                UpperLeft = tl;
                LowerRight = br;
            }
        }

        public readonly struct Region<B,T> : IRule<Region<B,T>,B,T>
        {
            public B Base {get;}

            public Pair<T> UpperLeft {get;}

            public Pair<T> LowerRight {get;}

            [MethodImpl(Inline)]
            public Region(B @base, Pair<T> tl, Pair<T> br)
            {
                Base = @base;
                UpperLeft = tl;
                LowerRight = br;
            }

            public static implicit operator Region(Region<B,T> src)
                => new Region(src.Base,
                    root.pair((dynamic)src.UpperLeft.Left, src.UpperLeft.Right),
                    root.pair((dynamic)src.LowerRight.Left, src.LowerRight.Right)
                    );
        }
    }
}