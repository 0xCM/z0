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

    /// <summary>
    /// Computes the FNV-1a hash of various things
    /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
    /// </summary>
    /// <param name="src">The data source</param>
    /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
    [ApiHost("alg.hash")]
    public readonly struct hash
    {
        const uint K = 0xA5555529;

        const uint FnvOffsetBias = 2166136261;

        const uint FnvPrime = 16777619;

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static uint calc(Type src)
            => (uint)src.MetadataToken;

        /// <summary>
        /// Creates a 64-bit calc code predicated on two types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong calc(Type t1, Type t2)
            => (ulong)calc(t1) | (ulong)calc(t2) << 32;

        /// <summary>
        /// Creates a 64-bit calc code predicated on three types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong calc(Type t1, Type t2, Type t3)
            => calc(t1,t2) ^ calc(t1, t3);

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint calc(sbyte x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint calc(byte x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(short x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(ushort x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(int x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(uint x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(ulong x)
            => calc((uint)x,(uint)(x >> 32));

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(long x)
            => calc((uint)x,(uint)(x >> 32));

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(char x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(float x)
            => calc((long)x);

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(double x)
            => calc(@ulong(x));

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(decimal x)
            => calc(@ulong(x));

        /// <summary>
        /// Creates an unsigned calc code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(bool x)
            => @byte(x);

        /// <summary>
        /// Computes a hash code for a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static uint calc(string src)
            => (uint)(src?.GetHashCode() ?? 0);

        /// <summary>
        /// Calculates a combined calc for 2 unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(uint x, uint y)
            => (y * K) + x;

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(sbyte x, sbyte y)
            => calc((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(byte x, byte y)
            => calc((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(short x, short y)
            => calc((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(ushort x, ushort y)
            => calc((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(int x, int y)
            => calc((uint)x, (uint)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(ulong x, ulong y)
            => calc(calc((uint)x,(uint)(x >> 32)), calc((uint)y,(uint)(y >> 32)));

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(long x, long y)
            => calc((ulong)x,(ulong)y);

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(float x, float y)
            => calc(@int(x), @int(y));

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(double x, double y)
            => calc(@ulong(x), @ulong(y));

        /// <summary>
        /// Creates a combined/unsigned calc code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint calc(decimal x, decimal y)
            => calc(@ulong(x) ,@ulong(y));

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
            return alg.hash.calc(v.GetElement(0), v.GetElement(1));
        }

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
        public static uint calc<T>(T x, T y)
            => calc_u(x,y);

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
                rolling = calc(rolling, calc(x,y))*FnvPrime;
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
                return calc(char16(src));
            else if(typeof(T) == typeof(bool))
                return calc(@bool(src));
            else
                return fallback(src);
        }

        [MethodImpl(Inline)]
        static uint calc_u<T>(T x, T y)
        {
            if(typeof(T) == typeof(byte))
                return calc(uint8(x), uint8(y));
            else if(typeof(T) == typeof(ushort))
                return calc(uint16(x), uint16(y));
            else if(typeof(T) == typeof(uint))
                return calc(uint32(x), uint32(y));
            else if(typeof(T) == typeof(ulong))
                return calc(uint64(x), uint64(y));
            else
                return calc_i(x,y);
        }

        [MethodImpl(Inline)]
        static uint calc_i<T>(T x, T y)
        {
            if(typeof(T) == typeof(sbyte))
                return calc(int8(x), int8(y));
            else if(typeof(T) == typeof(short))
                return calc(int16(x), int16(y));
            else if(typeof(T) == typeof(int))
                return calc(int32(x), int32(y));
            else if(typeof(T) == typeof(long))
                return calc(int64(x), int64(y));
            else
                return calc_f(x,y);
        }

        [MethodImpl(Inline)]
        static uint calc_f<T>(T x, T y)
        {
            if(typeof(T) == typeof(float))
                return calc(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return calc(float64(x), float64(y));
            else if(typeof(T) == typeof(decimal))
                return calc(float128(x), float128(y));
            else
                return fallback(x,y);
        }

        [MethodImpl(Inline)]
        static uint fallback<T>(T src)
            => (uint)(src?.GetHashCode() ?? 0);

        [MethodImpl(Inline)]
        static uint fallback<S,T>(S x, T y)
            => calc(
                (uint)(x?.GetHashCode() ?? 0),
                (uint)(y?.GetHashCode() ?? 0)
                );
    }
}