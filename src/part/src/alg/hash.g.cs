//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace alg
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0;

    using static Z0.Part;
    using static Z0.memory;

    partial struct hash
    {
        /// <summary>
        /// Creates a 64-bit calccode over a pair
        /// </summary>
        /// <param name="x">The first member</param>
        /// <param name="y">The second member</param>
        /// <typeparam name="X">The first member type</typeparam>
        /// <typeparam name="Y">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static ulong calc64<X,Y>(X x, Y y)
            => calc(x) | (calc(y) << 32);

        /// <summary>
        /// Creates a 32-bit calc code predicated on a type parameter
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static uint calc<T>()
            => calc(typeof(T));

        /// <summary>
        /// Creates a 64-bit calc code predicated on two type parameters
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong calc<S,T>()
            => (ulong)calc<S>() | (ulong)calc<T>() << 32;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint calc<T>(Vector128<T> src)
            where T : unmanaged
        {
            var v = src.AsUInt64();
            return alg.hash.combine(v.GetElement(0), v.GetElement(1));
        }

        /// <summary>
        /// Calculates a hash code for structured content and returns the content along with the calculated hash
        /// </summary>
        /// <param name="src">The source content</param>
        /// <typeparam name="C">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint bytehash<C>(C src)
            where C : struct
                => calc<byte>(bytes(src));

        /// <summary>
        /// Computes calc codes for unmanaged system primitives
        /// </summary>
        /// <param name="src">The primal value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint calc<T>(T src)
            => calc_u(src);

        /// <summary>
        /// Computes a combined calc code for a pair
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint combine<T>(T x, T y)
            => calc_u(x,y);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint calc<T>(T a, T b, T c, T d)
            => combine(combine(calc(a), calc(b)), combine(calc(c), calc(d)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint calc<T>(ReadOnlySpan<T> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var rolling = FnvOffsetBias;
            for(var i=0u; i<length-1; i++)
            {
                ref readonly var x = ref skip(src,i);
                ref readonly var y = ref skip(src,i + 1);
                rolling = combine(rolling, combine(x,y))*FnvPrime;
            }
            return rolling;
        }

        [MethodImpl(Inline)]
        public static uint calc<T>(Span<T> src)
            => calc(@readonly(src));

        [MethodImpl(Inline)]
        public static uint calc<T>(T[] src)
            => calc(span(src));

        [MethodImpl(Inline)]
        static uint calc_u<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                return calc(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return calc(uint16(src));
            else if(typeof(T) == typeof(uint))
                return calc(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return calc(uint64(src));
            else
                return calc_i(src);
        }

        [MethodImpl(Inline)]
        static uint calc_i<T>(T src)
        {
            if(typeof(T) == typeof(sbyte))
                return calc(int8(src));
            else if(typeof(T) == typeof(short))
                return calc(int16(src));
            else if(typeof(T) == typeof(int))
                return calc(int32(src));
            else if(typeof(T) == typeof(long))
                return calc(int64(src));
            else
                return calc_f(src);
        }

        [MethodImpl(Inline)]
        static uint calc_f<T>(T src)
        {
            if(typeof(T) == typeof(float))
                return calc(float32(src));
            else if(typeof(T) == typeof(double))
                return calc(float64(src));
            else if(typeof(T) == typeof(decimal))
                return calc(float128(src));
            else
                return calc_x(src);
        }

        [MethodImpl(Inline)]
        static uint calc_x<T>(T src)
        {
            if(typeof(T) == typeof(char))
                return calc(c16(src));
            else if(typeof(T) == typeof(bool))
                return calc(@bool(src));
            else
                return fallback(src);
        }

        [MethodImpl(Inline)]
        static uint calc_u<T>(T x, T y)
        {
            if(typeof(T) == typeof(byte))
                return combine(uint8(x), uint8(y));
            else if(typeof(T) == typeof(ushort))
                return combine(uint16(x), uint16(y));
            else if(typeof(T) == typeof(uint))
                return combine(uint32(x), uint32(y));
            else if(typeof(T) == typeof(ulong))
                return combine(uint64(x), uint64(y));
            else
                return calc_i(x,y);
        }

        [MethodImpl(Inline)]
        static uint calc_i<T>(T x, T y)
        {
            if(typeof(T) == typeof(sbyte))
                return combine(int8(x), int8(y));
            else if(typeof(T) == typeof(short))
                return combine(int16(x), int16(y));
            else if(typeof(T) == typeof(int))
                return combine(int32(x), int32(y));
            else if(typeof(T) == typeof(long))
                return combine(int64(x), int64(y));
            else
                return calc_f(x,y);
        }

        [MethodImpl(Inline)]
        static uint calc_f<T>(T x, T y)
        {
            if(typeof(T) == typeof(float))
                return combine(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return combine(float64(x), float64(y));
            else if(typeof(T) == typeof(decimal))
                return combine(float128(x), float128(y));
            else
                return fallback(x,y);
        }

        [MethodImpl(Inline)]
        static uint fallback<T>(T src)
            => (uint)(src?.GetHashCode() ?? 0);

        [MethodImpl(Inline)]
        static uint fallback<S,T>(S x, T y)
            => combine(
                (uint)(x?.GetHashCode() ?? 0),
                (uint)(y?.GetHashCode() ?? 0)
                );
    }
}