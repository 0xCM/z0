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
        /// Computes hash codes for unmanaged system primitives
        /// </summary>
        /// <param name="src">The primal value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T src)
            where T : unmanaged
                => hash_u(src);

        /// <summary>
        /// Computes combined hash codes for unmanaged system primitives
        /// </summary>
        /// <param name="src">The primal value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T x, T y)
            where T : unmanaged
                => hash_u(x,y);

        [MethodImpl(Inline)]
        static uint hash_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return hash(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return hash(uint16(src));
            else if(typeof(T) == typeof(uint))
                return hash(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return hash(uint64(src));

            return hash_i(src);
        }

        [MethodImpl(Inline)]
        static uint hash_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return hash(int8(src));
            else if(typeof(T) == typeof(short))
                return hash(int16(src));
            else if(typeof(T) == typeof(int))
                return hash(int32(src));
            else if(typeof(T) == typeof(long))
                return hash(int64(src));

            return hash_f(src);
        }

        [MethodImpl(Inline)]
        static uint hash_f<T>(T src)
            where T : unmanaged
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
            where T : unmanaged
        {
            if(typeof(T) == typeof(char))
                return hash(char16(src));
            else if(typeof(T) == typeof(bool))
                return hash(bool8(src));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static uint hash_u<T>(T x, T y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return hash(uint8(x), uint8(y));
            else if(typeof(T) == typeof(ushort))
                return hash(uint16(x), uint16(y));
            else if(typeof(T) == typeof(uint))
                return hash(uint32(x), uint32(y));
            else if(typeof(T) == typeof(ulong))
                return hash(uint64(x), uint64(y));

            return hash_i(x,y);
        }

        [MethodImpl(Inline)]
        static uint hash_i<T>(T x, T y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return hash(int8(x), int8(y));
            else if(typeof(T) == typeof(short))
                return hash(int16(x), int16(y));
            else if(typeof(T) == typeof(int))
                return hash(int32(x), int32(y));
            else if(typeof(T) == typeof(long))
                return hash(int64(x), int64(y));

            return hash_f(x,y);
        }

        [MethodImpl(Inline)]
        static uint hash_f<T>(T x, T y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return hash(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return hash(float64(x), float64(y));
            else if(typeof(T) == typeof(decimal))
                return hash(float128(x), float128(y));
            else
                throw no<T>();
        }
    }
}