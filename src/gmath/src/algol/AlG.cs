//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.AlG)]
    public readonly struct AlG
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Loop<I> loop<I>(Interval<I> bounds)
            where I : unmanaged
       {
            var dst = new Loop<I>();
            dst.LowerBound = bounds.Left;
            dst.UpperBound = bounds.Right;
            dst.LowerInclusive = bounds.LeftClosed;
            dst.UpperInclusive = bounds.RightClosed;
            return dst;
       }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ActionableLoop<I> join<I>(Loop<I> loop, ILoopAction<I> action)
            where I : unmanaged
       {
           var dst = new ActionableLoop<I>();
           dst.Loop = loop;
           dst.Action = action;
           return dst;
       }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelegatedLoop<I> join<I>(Loop<I> loop, Action<I> action)
            where I : unmanaged
       {
           var dst = new DelegatedLoop<I>();
           dst.Loop = loop;
           dst.Action = action;
           return dst;
       }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HostedLoop<Accrue<I>,I> accrue<I>(Loop<I> loop, Accrue<I> h = default)
            where I : unmanaged
                => host(loop, h);

        [MethodImpl(Inline)]
        public static HostedLoop<H,I> loop<H,I>(Interval<I> bounds, H h = default)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
                => host(loop(bounds),h);

        [MethodImpl(Inline)]
        public static HostedLoop<H,I> host<H,I>(in Loop<I> loop, in  H host)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var dst = new HostedLoop<H,I>();
            dst.Host = host;
            dst.Loop = loop;
            return dst;
        }

        [MethodImpl(Inline)]
        public static void run<H,I>(in HostedLoop<H,I> runnable)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var loop =  runnable.Loop;
            var host = runnable.Host;
            var min = int64(loop.LowerBound);
            var max = int64(loop.UpperBound);
            for(var a=min; a<max; a++)
                host.Step(@as<long,I>(a));
        }

        [MethodImpl(Inline)]
        public static void run2<H,I>(in HostedLoop<H,I> a)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var loop = a.Loop;
            var host = a.Host;
            var max = loop.UpperBound;
            var i = loop.LowerBound;
            while(gmath.lt(i, max))
            {
                host.Step(i);
                i = gmath.inc(i);
            }
        }
    }
}