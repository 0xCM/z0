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

    using static Seed;
    using static Memories;

    using static gmath;

    [ApiHost]
    class Algorithms : IApiHost<Algorithms>
    {
        /// <summary>
        /// Populates a memory target with values first, first + 1*step, first + 2*step ... first + (n - 1)*step
        /// </summary>
        /// <param name="first">The first value</param>
        /// <param name="step">The step size</param>
        /// <param name="count">The number of values to produce</param>
        /// <param name="dst">The memory target</param>
        /// <typeparam name="T">The target value type</typeparam>    
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void steps<T>(T first, T step, int count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = gmath.add(first, gmath.mul(convert<T>(i),step));
        }

        [Op, Closures(UnsignedInts)]
        public static Span<T> increments<T>(Interval<T> src)
            where T : unmanaged
        {
            var min = src.Left;
            var max = src.Right;
            var current = min;
            var count = convert<T,int>(src.Length()) + 1;
            //var increments = new List<T>(convert<T,int>(src.Length()) + 1);
            Span<T> increments = new T[count];
            var index = 0;
            while(lteq(current,max) && index < increments.Length)
            {
                //increments.Add(current);
                seek(increments, index++) = current;
                
                if(lt(current, max))
                    current = inc(current);
                else
                    break;
            }
            
            return increments;
        }

        /// <summary>
        /// Determines whether an interval contains a specified point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="point">The point to test</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit contains<T>(Interval<T> src, T point)
            where T : unmanaged
        {
            switch(src.Kind)
            {
                case IntervalKind.Closed:
                    return gteq(point, src.Left) && lteq(point, src.Right);
                case IntervalKind.Open:
                    return gt(point, src.Left) && lt(point, src.Right);
                case IntervalKind.LeftClosed:
                    return gteq(point, src.Left) && lt(point, src.Right);
                default:        
                    return gt(point, src.Left) && lteq(point, src.Right);
            }
        }                

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit contains<T>(Span<T> xs, T match)  
            where T : unmanaged       
            => contains(ref head(xs), match, xs.Length);

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit contains<T>(ref T src, T match, int length)
            where T : unmanaged
        {
            IntPtr index = (IntPtr)0;

            while (length >= 8)
            {
                length -= 8;

                if (eq(match, offset(ref src, index + 0)) ||
                    eq(match, offset(ref src, index + 1)) ||
                    eq(match, offset(ref src, index + 2)) ||
                    eq(match, offset(ref src, index + 3)) ||
                    eq(match, offset(ref src, index + 4)) ||
                    eq(match, offset(ref src, index + 5)) ||
                    eq(match, offset(ref src, index + 6)) ||
                    eq(match, offset(ref src, index + 7)))
                return true;
                
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (eq(match, offset(ref src, index + 0)) ||
                    eq(match, offset(ref src, index + 1)) ||
                    eq(match, offset(ref src, index + 2)) ||
                    eq(match, offset(ref src, index + 3)))
                return true;

                index += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (eq(match, offset(ref src, index)))
                    return true;

                index += 1;
            }
            return false;        
        }          

        /// <summary>
        /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> sequence<T>(T x0, T x1)
            where T : unmanaged
                => range_1(x0,x1,null);

        /// <summary>
        /// Defines a scalar sequence {0,1,...,count-1}
        /// </summary>
        /// <param name="count">The number of elements in the sequence</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> counted<T>(T count)
            where T : unmanaged
                => sequence(default(T), count);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> range<T>(T x0, T x1)
            where T : unmanaged
                => sequence(x0,x1);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static IEnumerable<T> range<T>(T x0, T x1, T step)
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
                throw Unsupported.define<T>();
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
            return Algorithms.identical(ref head(xs), ref head(ys), xs.Length);
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
            return Algorithms.identical(ref edit(in head(xs)), ref edit(in head(ys)), xs.Length);
        }        

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit identical<T>(ref T first, ref T second, int length)
            where T : unmanaged
        {
            if (Unsafe.AreSame(ref first, ref second))
                return true;

            IntPtr offset = (IntPtr)0; 
            T x;
            T y;
            while (length >= 8)
            {
                length -= 8;
                
                x = offset<T>(ref first, offset + 0);
                y = offset<T>(ref second, offset + 0);
                if(neq(x, y))
                    return false;                
                x = offset<T>(ref first, offset + 1);
                y = offset<T>(ref second, offset + 1);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 2);
                y = offset<T>(ref second, offset + 2);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 3);
                y = offset<T>(ref second, offset + 3);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 4);
                y = offset<T>(ref second, offset + 4);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 5);
                y = offset<T>(ref second, offset + 5);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 6);
                y = offset<T>(ref second, offset + 6);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 7);
                y = offset<T>(ref second, offset + 7);
                if(neq(x, y))
                    return false;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                x = offset<T>(ref first, offset);
                y = offset<T>(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 1);
                y = offset<T>(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 2);
                y = offset<T>(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 3);
                y = offset<T>(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (length > 0)
            {
                x = offset<T>(ref first, offset);
                y = offset<T>(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                length--;
            }

            return true;
        } 
    }
}