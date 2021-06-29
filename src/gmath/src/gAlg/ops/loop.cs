//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct gAlg
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Accrue<I> run<I>(Loop<I> loop, ref Accrue<I> dst)
            where I : unmanaged, IComparable<I>
        {
            var min = int64(loop.LowerBound) + (loop.LowerInclusive ? 0 : -1);
            var max = int64(loop.UpperBound) + (loop.UpperInclusive ? 1 : 0);
            for(var a=min; a<max; a++)
                dst.Next(@as<long,I>(a));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Loop<I> loop<I>(Interval<I> bounds, I? step = null)
            where I : unmanaged, IComparable<I>
       {
            var dst = new Loop<I>();
            dst.LowerBound = bounds.Left;
            dst.UpperBound = bounds.Right;
            dst.LowerInclusive = bounds.LeftClosed;
            dst.UpperInclusive = bounds.RightClosed;
            dst.Step = step ?? NumericLiterals.one<I>();
            return dst;
       }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void loop<T>(Pair<T> limits, Func<T,T> f, Action<T> g)
            where T : unmanaged
        {
            var min = limits.Left;
            var max = limits.Right;
            var i = min;
            while(gmath.lt(i,max))
            {
                g(f(i));
                i = gmath.inc(i);
            }
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void loop<T>(in T min, in T max, Action<T> f, in T step)
            where T : unmanaged
        {
            var i = min;
            while(gmath.lt(i,max))
            {
                f(i);
                i = gmath.add(i,step);
            }
        }
    }
}