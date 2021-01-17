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
        public interface IRegion
        {
            dynamic Base {get;}

            Pair<dynamic> TopLeft {get;}

            Pair<dynamic> BottomRight {get;}
        }

        public interface IRegion<B,T> : IRegion
        {
            /// <summary>
            /// A value to which the region coordinates are relative
            /// </summary>
            new B Base {get;}

            new Pair<T> TopLeft {get;}

            new Pair<T> BottomRight {get;}

            dynamic IRegion.Base
                => Base;

            Pair<dynamic> IRegion.TopLeft
                => (TopLeft.Left, TopLeft.Right);

            Pair<dynamic> IRegion.BottomRight
                => (BottomRight.Left, BottomRight.Right);
        }


        public readonly struct Region : IRegion
        {
            public dynamic Base {get;}

            public Pair<dynamic> TopLeft {get;}

            public Pair<dynamic> BottomRight {get;}

            [MethodImpl(Inline)]
            public Region(dynamic @base, Pair<dynamic> tl, Pair<dynamic> br)
            {
                Base = @base;
                TopLeft = tl;
                BottomRight = br;
            }
        }

        public readonly struct Region<B,T> : IRegion<B,T>
        {
            public B Base {get;}

            public Pair<T> TopLeft {get;}

            public Pair<T> BottomRight {get;}

            [MethodImpl(Inline)]
            public Region(B @base, Pair<T> tl, Pair<T> br)
            {
                Base = @base;
                TopLeft = tl;
                BottomRight = br;
            }
        }
    }
}