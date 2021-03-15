//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct gAlg
    {
        const NumericKind Closure = UnsignedInts;

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
            dst.Step = step ?? Numeric.one<I>();
            return dst;
       }

        [Op, Closures(AllNumeric)]
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

        [Op, Closures(AllNumeric)]
        public static void loop<T>(in T min, in T max, Action<T> f, in T step)
            where T : unmanaged
                => loop_1(min, max, f, step);

        [MethodImpl(Inline)]
        static void loop_1<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                loop8i(x0, x1, f, step);
            else if(typeof(T) == typeof(byte))
                loop8u(x0, x1, f, step);
            else if(typeof(T) == typeof(short))
                loop16i(x0, x1, f, step);
            else if(typeof(T) == typeof(ushort))
                loop16u(x0, x1, f, step);
            else
                loop_2(x0, x1, f, step);
        }

        [MethodImpl(Inline)]
        static void loop_2<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            if(typeof(T) == typeof(int))
                loop32i(x0, x1, f, step);
            else if(typeof(T) == typeof(uint))
                loop32u(x0, x1, f, step);
            else if(typeof(T) == typeof(long))
                loop64i(x0, x1, f, step);
            else if(typeof(T) == typeof(ulong))
                loop64u(x0, x1, f, step);
            else
                loop_3(x0, x1, f, step);
        }

        [MethodImpl(Inline)]
        static void loop_3<T>(in T x0,in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                loop32f(x0, x1, f, step);
            else if(typeof(T) == typeof(double))
                loop64f(x0, x1, f, step);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        static void loop8i<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,sbyte>(x0);
            var max = @as<T,sbyte>(x1);
            var _step = @as<T,sbyte>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<sbyte,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        static void loop8u<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,byte>(x0);
            ref readonly var max = ref @as<T,byte>(x1);
            var _step = @as<T, byte>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<byte,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(Int16k)]
        static void loop16i<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,short>(x0);
            ref readonly var max = ref @as<T,short>(x1);
            var _step = @as<T, short>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<short,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(UInt16k)]
        static void loop16u<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,ushort>(x0);
            ref readonly var max = ref @as<T,ushort>(x1);
            var _step = @as<T, ushort>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<ushort,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(Int32k)]
        static void loop32i<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,int>(x0);
            ref readonly var max = ref @as<T,int>(x1);
            var _step = @as<T, int>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<int,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        static void loop32u<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,uint>(x0);
            ref readonly var max = ref @as<T,uint>(x1);
            var _step = @as<T, uint>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<uint,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(Int64k)]
        static void loop64i<T>(in T x0, in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,long>(x0);
            ref readonly var max = ref @as<T,long>(x1);
            var _step = @as<T,long>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<long,T>(i));
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        static void loop64u<T>(in T x0,in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,ulong>(x0);
            ref readonly var max = ref @as<T,ulong>(x1);
            var _step = @as<T,ulong>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<ulong,T>(i));
        }

        [MethodImpl(Inline)]
        static void loop32f<T>(in T x0,in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,float>(x0);
            ref readonly var max = ref @as<T,float>(x1);
            var _step = @as<T,float>(step);
            for(var i = min; i <= max; i += _step)
                f(@as<float,T>(i));
        }

        [MethodImpl(Inline)]
        static void loop64f<T>(in T x0,in T x1, Action<T> f, in T step)
            where T : unmanaged
        {
            ref readonly var min = ref @as<T,double>(x0);
            ref readonly var max = ref @as<T,double>(x1);
            var _step = @as<T,double>(step);;
            for(var i = min; i <= max; i += _step)
                f(@as<double,T>(i));
        }
    }
}