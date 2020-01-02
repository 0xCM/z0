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

    partial class gmath
    {
        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="t">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline)]
        public static bit between<T>(T t, T min, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return between_u(t,min,max);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return between_i(t,min,max);
            else
                return gfp.between(t,min,max);
        }

        [MethodImpl(Inline)]
        static bit between_i<T>(T x, T min, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.between(int8(x), int8(min), int8(max));
            if(typeof(T) == typeof(short))
                return math.between(int16(x), int16(min), int16(max));
            if(typeof(T) == typeof(int))
                return math.between(int32(x), int32(min), int32(max));
            else 
                return math.between(int64(x), int64(min), int64(max));
        }

        [MethodImpl(Inline)]
        static bit between_u<T>(T x, T min, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.between(uint8(x), uint8(min), uint8(max));
            else if(typeof(T) == typeof(ushort))
                return math.between(uint16(x), uint16(min), uint16(max));
            else if(typeof(T) == typeof(uint))
                return math.between(uint32(x), uint32(min), uint32(max));
            else 
                return math.between(uint64(x), uint64(min), uint64(max));
        }
    }
}