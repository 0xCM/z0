//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct GridRegion
    {
        public GridPoint UpperLeft {get;}

        public GridPoint LowerRight {get;}

        [MethodImpl(Inline)]
        public GridRegion(GridPoint upper, GridPoint lower)
        {
            UpperLeft = upper;
            LowerRight = lower;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridRegion((GridPoint upper, GridPoint lower) src)
            => new GridRegion(src.upper,src.lower);
    }
}