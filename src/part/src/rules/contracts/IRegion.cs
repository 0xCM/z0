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

            Pair<dynamic> UpperLeft {get;}

            Pair<dynamic> LowerRight {get;}
        }

        public interface IRegion<B,T> : IRegion
        {
            /// <summary>
            /// A value to which the region coordinates are relative
            /// </summary>
            new B Base {get;}

            new Pair<T> UpperLeft {get;}

            new Pair<T> LowerRight {get;}

            dynamic IRegion.Base
                => Base;

            Pair<dynamic> IRegion.UpperLeft
                => (UpperLeft.Left, UpperLeft.Right);

            Pair<dynamic> IRegion.LowerRight
                => (LowerRight.Left, LowerRight.Right);
        }
    }
}