//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Loop<I> loop<I>(Interval<I> bounds, I? step = null)
            where I : unmanaged
       {
            var dst = new Loop<I>();
            dst.LowerBound = bounds.Left;
            dst.UpperBound = bounds.Right;
            dst.LowerInclusive = bounds.LeftClosed;
            dst.UpperInclusive = bounds.RightClosed;
            dst.Step = step ?? NumericLiterals.one<I>();
            return dst;
       }
    }
}