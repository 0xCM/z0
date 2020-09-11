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


    [ApiHost]
    public readonly struct BranchTables
    {
        [Op]
        public uint map1(ushort src)
        {
            switch(src)
            {
                case 12:
                    return 33u*src;
                case 90:
                    return 66u*src;
                case 190:
                    return 12u*src;
                case 7:
                    return 2u*src;
                case 25000:
                    return 422u*src;
                case 35000:
                    return 522u*src;
                default:
                    return uint.MaxValue;
            }

        }

        [Op]
        public uint map2(byte src)
        {
            switch(src)
            {
                default:
                return 13;

            }

        }

    }

    public struct BranchProcessor
    {
        public ushort f1(byte src)
            => math.and(src, (byte)15);


    }

    public ref struct BranchTable<S,T>
        where S : unmanaged
    {
        readonly Span<IBranchMap<S,T>> Branches;

        [MethodImpl(Inline)]
        public BranchTable(IBranchMap<S,T>[] src)
        {
            Branches = src;
        }
    }

    public interface IBranchMap<S,T>
        where S : unmanaged
    {
        T Apply(S src);

    }


    public interface IBranchMap<H,S,T> : IBranchMap<S,T>
        where S : unmanaged
        where H : struct, IBranchMap<H,S,T>
    {
    }


    public struct Loop<I>
        where I : unmanaged
    {
        public I Lower;

        public bool LowerInclusive;

        public I Upper;

        public bool UpperInclusive;

    }

    public struct ActionableLoop<I>
        where I : unmanaged
    {
        public Loop<I> Loop;

        public ILoopAction<I> Action;
    }

    public struct DelegatedLoop<I>
        where I : unmanaged
    {
        public Loop<I> Loop;

        public Action<I> Action;
    }


    public struct HostedLoop<H,I>
        where I : unmanaged
        where H : struct, ILoopHost<H,I>
    {

        public H Host;

        public Loop<I> Loop;
    }

    public interface ILoopAction<I>
    {
        void Step(I i);
    }

    public interface ILoopHost<H,I> : ILoopAction<I>
        where H : struct, ILoopHost<H,I>
    {

    }

    public struct Accrue<I> : ILoopHost<Accrue<I>,I>
        where I : unmanaged
    {
        I Total;

        [MethodImpl(Inline)]
        public void Step(I i)
        {
            Total = gmath.add(Total,i);
        }
    }

    [ApiHost]
    public readonly struct Algorithmic
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Loop<I> loop<I>(Interval<I> bounds)
            where I : unmanaged
       {
            var dst = new Loop<I>();
            dst.Lower = bounds.Left;
            dst.Upper = bounds.Right;
            dst.LowerInclusive = bounds.LeftClosed;
            dst.UpperInclusive = bounds.RightClosed;
            return dst;
       }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ActionableLoop<I> join<I>(Loop<I> loop, ILoopAction<I> action)
            where I : unmanaged
       {
           var dst = new ActionableLoop<I>();
           dst.Loop = loop;
           dst.Action = action;
           return dst;
       }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DelegatedLoop<I> join<I>(Loop<I> loop, Action<I> action)
            where I : unmanaged
       {
           var dst = new DelegatedLoop<I>();
           dst.Loop = loop;
           dst.Action = action;
           return dst;
       }

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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HostedLoop<Accrue<I>,I> accrue<I>(Loop<I> loop, Accrue<I> h = default)
            where I : unmanaged
                => host(loop, h);

        [MethodImpl(Inline)]
        public static void run<H,I>(in HostedLoop<H,I> runnable)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
        {
            var loop =  runnable.Loop;
            var host = runnable.Host;
            var min = int64(loop.Lower);
            var max = int64(loop.Upper);
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
            var max = loop.Upper;
            var i = loop.Lower;
            while(gmath.lt(i, max))
            {
                host.Step(i);
                i = gmath.inc(i);
            }
        }



    }

    [ApiHost]
    public static partial class XRun
    {
        [MethodImpl(Inline)]
        public static void Run<H,I>(this HostedLoop<H,I> runnable)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
                => Algorithmic.run(runnable);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void Run1<I>(this HostedLoop<Accrue<I>,I> runnable)
            where I : unmanaged
                => Algorithmic.run(runnable);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void Run2<I>(this HostedLoop<Accrue<I>,I> runnable)
            where I : unmanaged
                => Algorithmic.run2(runnable);
    }
}