//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a 64-bit hashcode over a pair
        /// </summary>
        /// <param name="x">The first member</param>
        /// <param name="y">The second member</param>
        /// <typeparam name="X">The first member type</typeparam>
        /// <typeparam name="Y">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash64<X,Y>(X x, Y y)
            => hash(x) | (hash(y) << 32);

        /// <summary>
        /// Creates a 32-bit hash code predicated on a type parameter
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static uint hash<T>()
            => hash(typeof(T));

        /// <summary>
        /// Creates a 64-bit hash code predicated on two type parameters
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash<S,T>()
            => (ulong)hash<S>() | (ulong)hash<T>() << 32;

        /// <summary>
        /// Computes hash codes for unmanaged system primitives
        /// </summary>
        /// <param name="src">The primal value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T src)
            => hash_u(src);

        /// <summary>
        /// Computes a combined hash code for a pair
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T x, T y)
            => hash_u(x,y);

        [MethodImpl(Inline)]
        static uint hash_u<T>(T src)
        {
            if(typeof(T) == typeof(byte))
                return hash(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return hash(uint16(src));
            else if(typeof(T) == typeof(uint))
                return hash(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return hash(uint64(src));
            else
                return hash_i(src);
        }

        [MethodImpl(Inline)]
        static uint hash_i<T>(T src)
        {
            if(typeof(T) == typeof(sbyte))
                return hash(int8(src));
            else if(typeof(T) == typeof(short))
                return hash(int16(src));
            else if(typeof(T) == typeof(int))
                return hash(int32(src));
            else if(typeof(T) == typeof(long))
                return hash(int64(src));
            else
                return hash_f(src);
        }

        [MethodImpl(Inline)]
        static uint hash_f<T>(T src)
        {
            if(typeof(T) == typeof(float))
                return hash(float32(src));
            else if(typeof(T) == typeof(double))
                return hash(float64(src));
            else if(typeof(T) == typeof(decimal))
                return hash(float128(src));
            else
                return hash_x(src);
        }

        [MethodImpl(Inline)]
        static uint hash_x<T>(T src)
        {
            if(typeof(T) == typeof(char))
                return hash(char16(src));
            else if(typeof(T) == typeof(bool))
                return hash(@bool(src));
            else
                return fallback(src);
        }

        [MethodImpl(Inline)]
        static uint hash_u<T>(T x, T y)
        {
            if(typeof(T) == typeof(byte))
                return hash(uint8(x), uint8(y));
            else if(typeof(T) == typeof(ushort))
                return hash(uint16(x), uint16(y));
            else if(typeof(T) == typeof(uint))
                return hash(uint32(x), uint32(y));
            else if(typeof(T) == typeof(ulong))
                return hash(uint64(x), uint64(y));
            else
                return hash_i(x,y);
        }

        [MethodImpl(Inline)]
        static uint hash_i<T>(T x, T y)
        {
            if(typeof(T) == typeof(sbyte))
                return hash(int8(x), int8(y));
            else if(typeof(T) == typeof(short))
                return hash(int16(x), int16(y));
            else if(typeof(T) == typeof(int))
                return hash(int32(x), int32(y));
            else if(typeof(T) == typeof(long))
                return hash(int64(x), int64(y));
            else
                return hash_f(x,y);
        }

        [MethodImpl(Inline)]
        static uint hash_f<T>(T x, T y)
        {
            if(typeof(T) == typeof(float))
                return hash(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return hash(float64(x), float64(y));
            else if(typeof(T) == typeof(decimal))
                return hash(float128(x), float128(y));
            else
                return fallback(x,y);
        }

        [MethodImpl(Inline)]
        static uint fallback<T>(T src)
            => (uint)(src?.GetHashCode() ?? 0);

        [MethodImpl(Inline)]
        static uint fallback<S,T>(S x, T y)
            => hash(
                (uint)(x?.GetHashCode() ?? 0),
                (uint)(y?.GetHashCode() ?? 0)
                );
    }
}