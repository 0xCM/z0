//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static gmath;
    using static z;

    [ApiHost]
    public readonly struct Ranges
    {
       [MethodImpl(Inline), Op, Closures(Integers)]
       public static void range8i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,sbyte>(ref x0);
            var max = Unsafe.As<T,sbyte>(ref x1);
            var _step = Unsafe.As<T?, sbyte?>(ref step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<sbyte,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range8u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,byte>(ref x0);
            var max = Unsafe.As<T,byte>(ref x1);
            var _step = Unsafe.As<T?, byte?>(ref step) ??(byte)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<byte,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range16i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,short>(ref x0);
            var max = Unsafe.As<T,short>(ref x1);
            var _step = Unsafe.As<T?, short?>(ref step) ?? (short)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<short,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range16u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ushort>(ref x0);
            var max = Unsafe.As<T,ushort>(ref x1);
            var _step = Unsafe.As<T?, ushort?>(ref step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<ushort,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range32i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,int>(ref x0);
            var max = Unsafe.As<T,int>(ref x1);
            var _step = Unsafe.As<T?, int?>(ref step) ?? 1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<int,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range32u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,uint>(ref x0);
            var max = Unsafe.As<T,uint>(ref x1);
            var _step = Unsafe.As<T?, uint?>(ref step) ?? 1u;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<uint,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range64i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,long>(ref x0);
            var max = Unsafe.As<T,long>(ref x1);
            var _step = Unsafe.As<T?, long?>(ref step) ?? 1L;
            for(var i = min; i <= max; i += _step)
                seek(dst,i) = Unsafe.As<long,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range64u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ulong>(ref x0);
            var max = Unsafe.As<T,ulong>(ref x1);
            var _step = Unsafe.As<T?, ulong?>(ref step) ?? 1ul;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<ulong,T>(ref i);
        }
    }

    [ApiHost]
    public readonly partial struct Algorithmic
    {
        /// <summary>
        /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> stream<T>(T x0, T x1)
            where T : unmanaged
                => range_1(x0,x1,null);

        /// <summary>
        /// Defines a scalar sequence {0,1,...,count-1}
        /// </summary>
        /// <param name="count">The number of elements in the sequence</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> stream<T>(T count)
            where T : unmanaged
                => stream(default(T), count);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> stream<T>(T x0, T x1, T step)
            where T : unmanaged
                => range_1(x0, x1, step);

        [MethodImpl(Inline)]
        static IEnumerable<T> range_1<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return range8i(x0,x1,step);
            else if(typeof(T) == typeof(byte))
                return range8u(x0,x1,step);
            else if(typeof(T) == typeof(short))
                return range16i(x0,x1,step);
            else if(typeof(T) == typeof(ushort))
                return range16u(x0,x1,step);
            else
                return range_2(x0,x1,step);
        }

        [MethodImpl(Inline)]
        static IEnumerable<T> range_2<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(int))
                return range32i(x0,x1,step);
            else if(typeof(T) == typeof(uint))
                return range32u(x0,x1,step);
            else if(typeof(T) == typeof(long))
                return range64i(x0,x1,step);
            else if(typeof(T) == typeof(ulong))
                return range64u(x0,x1,step);
            else
                return range_3(x0,x1,step);
        }

        [MethodImpl(Inline)]
        static IEnumerable<T> range_3<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return range32f(x0,x1,step);
            else if(typeof(T) == typeof(double))
                return range64f(x0,x1,step);
            else
                throw no<T>();
        }

        static IEnumerable<T> range8i<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,sbyte>(ref x0);
            var max = Unsafe.As<T,sbyte>(ref x1);
            var _step = Unsafe.As<T?, sbyte?>(ref step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<sbyte,T>(ref i);
        }

        static IEnumerable<T> range8u<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,byte>(ref x0);
            var max = Unsafe.As<T,byte>(ref x1);
            var _step = Unsafe.As<T?, byte?>(ref step) ??(byte)1;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<byte,T>(ref i);
        }

        static IEnumerable<T> range16i<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,short>(ref x0);
            var max = Unsafe.As<T,short>(ref x1);
            var _step = Unsafe.As<T?, short?>(ref step) ?? (short)1;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<short,T>(ref i);
        }

        static IEnumerable<T> range16u<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ushort>(ref x0);
            var max = Unsafe.As<T,ushort>(ref x1);
            var _step = Unsafe.As<T?, ushort?>(ref step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<ushort,T>(ref i);
        }

        static IEnumerable<T> range32i<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,int>(ref x0);
            var max = Unsafe.As<T,int>(ref x1);
            var _step = Unsafe.As<T?, int?>(ref step) ?? 1;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<int,T>(ref i);
        }

        static IEnumerable<T> range32u<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,uint>(ref x0);
            var max = Unsafe.As<T,uint>(ref x1);
            var _step = Unsafe.As<T?, uint?>(ref step) ?? 1u;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<uint,T>(ref i);
        }

        static IEnumerable<T> range64i<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,long>(ref x0);
            var max = Unsafe.As<T,long>(ref x1);
            var _step = Unsafe.As<T?, long?>(ref step) ?? 1L;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<long,T>(ref i);
        }

        static IEnumerable<T> range64u<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ulong>(ref x0);
            var max = Unsafe.As<T,ulong>(ref x1);
            var _step = Unsafe.As<T?, ulong?>(ref step) ?? 1ul;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<ulong,T>(ref i);
        }

        static IEnumerable<T> range32f<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,float>(ref x0);
            var max = Unsafe.As<T,float>(ref x1);
            var _step = Unsafe.As<T?, float?>(ref step) ?? 1f;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<float,T>(ref i);
        }

        static IEnumerable<T> range64f<T>(T x0, T x1, T? step = null)
            where T : unmanaged
        {
            var min = Unsafe.As<T,double>(ref x0);
            var max = Unsafe.As<T,double>(ref x1);
            var _step = Unsafe.As<T?, double?>(ref step) ?? 1d;
            for(var i = min; i <= max; i += _step)
                yield return Unsafe.As<double,T>(ref i);
        }

        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit identical<T>(Span<T> xs, Span<T> ys)
            where T : unmanaged
        {
            if(xs.Length != ys.Length)
                return false;
            return Algorithmic.identical(ref z.first(xs), ref z.first(ys), (uint)xs.Length);
        }

        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit identical<T>(ReadOnlySpan<T> xs, ReadOnlySpan<T> ys)
            where T : unmanaged
        {
            if(xs.Length != ys.Length)
                return false;
            return Algorithmic.identical(ref z.edit(in z.first(xs)), ref z.edit(in z.first(ys)), (uint)xs.Length);
        }

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit identical<T>(ref T first, ref T second, uint count)
            where T : unmanaged
        {
            if (Unsafe.AreSame(ref first, ref second))
                return true;

            var offset = 0;
            T x;
            T y;
            while (count >= 8)
            {
                count -= 8;

                x = z.add<T>(first, offset + 0);
                y = z.add<T>(second, offset + 0);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 1);
                y = z.add<T>(second, offset + 1);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 2);
                y = z.add<T>(second, offset + 2);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 3);
                y = z.add<T>(second, offset + 3);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 4);
                y = z.add<T>(second, offset + 4);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 5);
                y = z.add<T>(second, offset + 5);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 6);
                y = z.add<T>(second, offset + 6);
                if(neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 7);
                y = z.add<T>(second, offset + 7);
                if(neq(x, y))
                    return false;

                offset += 8;
            }

            if (count >= 4)
            {
                count -= 4;

                x = z.add<T>(first, offset);
                y = z.add<T>(second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 1);
                y = z.add<T>(second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 2);
                y = z.add<T>(second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = z.add<T>(first, offset + 3);
                y = z.add<T>(second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (count > 0)
            {
                x = z.add<T>(first, offset);
                y = z.add<T>(second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                count--;
            }

            return true;
        }
    }
}