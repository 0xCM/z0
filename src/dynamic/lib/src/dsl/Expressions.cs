//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Expressions
    {
        const NumericKind Closure = UnsignedInts;

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

        [MethodImpl(Inline)]
        public static LoopHost<H,I> loop<H,I>(Interval<I> bounds, H h = default)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
                => host(loop(bounds),h);

        [MethodImpl(Inline)]
        public static LoopHost<H,I> host<H,I>(in Loop<I> loop, in  H host)
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