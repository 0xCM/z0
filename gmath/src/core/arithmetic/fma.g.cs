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
        [MethodImpl(Inline)]
        public static T fma<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return fma_u(x,a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return fma_i(x,a,b);
            else
                return gfp.fma(x,a,b);
        }

        [MethodImpl(Inline)]
        static T fma_i<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.fma(int8(x), int8(a), int8(b)));
            if(typeof(T) == typeof(short))
                return generic<T>(math.fma(int16(x), int16(a), int16(b)));
            if(typeof(T) == typeof(int))
                return generic<T>(math.fma(int32(x), int32(a), int32(b)));
            else 
                return generic<T>(math.fma(int64(x), int64(a), int64(b)));
        }

        [MethodImpl(Inline)]
        static T fma_u<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.fma(uint8(x), uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.fma(uint16(x), uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.fma(uint32(x), uint32(a), uint32(b)));
            else 
                return generic<T>(math.fma(uint64(x), uint64(a), uint64(b)));
        }
    }
}