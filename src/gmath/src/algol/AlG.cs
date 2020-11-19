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
        public static IntegralLoop<I> loop<I>(Interval<I> bounds)
            where I : unmanaged
       {
            var dst = new IntegralLoop<I>();
            dst.LowerBound = bounds.Left;
            dst.UpperBound = bounds.Right;
            dst.LowerInclusive = bounds.LeftClosed;
            dst.UpperInclusive = bounds.RightClosed;
            return dst;
       }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LoopAction<I> join<I>(IntegralLoop<I> loop, IIntegralLoop<I> action)
            where I : unmanaged
       {
           var dst = new LoopAction<I>();
           dst.Loop = loop;
           dst.Action = action;
           return dst;
       }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LoopHost<Accrue<I>,I> accrue<I>(IntegralLoop<I> loop, Accrue<I> h = default)
            where I : unmanaged
                => host(loop, h);

        [MethodImpl(Inline)]
        public static LoopHost<H,I> loop<H,I>(Interval<I> bounds, H h = default)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
                => host(loop(bounds),h);

        [MethodImpl(Inline)]
        public static LoopHost<H,I> host<H,I>(in IntegralLoop<I> loop, in  H host)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var dst = new LoopHost<H,I>();
            dst.Host = host;
            dst.Loop = loop;
            return dst;
        }

        [MethodImpl(Inline)]
        public static void run<H,I>(in LoopHost<H,I> spec)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var loop =  spec.Loop;
            var host = spec.Host;
            var min = int64(loop.LowerBound);
            var max = int64(loop.UpperBound);
            for(var a=min; a<max; a++)
                host.Step(@as<long,I>(a));
        }
    }
}