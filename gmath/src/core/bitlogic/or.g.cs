//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {        
        /// <summary>
        /// Computes the bitwise or between two primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return or_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return or_i(a,b);
            else 
                return gfp.or(a,b);
        }

        /// <summary>
        /// Computes the bitwise or between three primal values
        /// </summary>
        /// <param name="a">The left value</param>
        /// <param name="b">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T a, T b, T c)
            where T : unmanaged
                => or_u(a,b,c);

        [MethodImpl(Inline)]
        static T or_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.or(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.or(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.or(int32(a), int32(b)));
            else
                 return generic<T>(math.or(int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T or_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.or(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.or(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.or(uint32(a), uint32(b)));
            else 
                return generic<T>(math.or(uint64(a), uint64(b)));
        }

        [MethodImpl(Inline)]
        static T or_u<T>(T a, T b, T c)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.or(uint8(a), uint8(b), uint8(c)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.or(uint16(a), uint16(b), uint16(c)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.or(uint32(a), uint32(b), uint32(c)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.or(uint64(a), uint64(b), uint64(c)));
            else
                return or_i(a,b,c);
        }

        [MethodImpl(Inline)]
        static T or_i<T>(T a, T b, T c)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.or(int8(a), int8(b), int8(c)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.or(int16(a), int16(b), int16(c)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.or(int32(a), int32(b), int32(c)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.or(int64(a), int64(b), int64(c)));
            else
                throw unsupported<T>();
        }
    }
}
