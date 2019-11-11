//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static AsIn;    
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector256<T> vblendv<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblendv_u(x,y,spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblendv_i(x,y,spec);
            else 
                return vblendv_f(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblendv_i<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vblend32x8(int8(x), int8(y), int8(spec)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vblend16x16(int16(x), int16(y), int16(spec)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vblend8x32(int32(x), int32(y), int32(spec)));
            else
                 return generic<T>(dinx.vblend4x64(int64(x), int64(y), int64(spec)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vblendv_u<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vblend32x8(uint8(x), uint8(y), uint8(spec)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vblend16x16(uint16(x), uint16(y), uint16(spec)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vblend8x32(uint32(x), uint32(y), uint32(spec)));
            else 
                return generic<T>(dinx.vblend4x64(uint64(x), uint64(y), uint64(spec)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vblendv_f<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vblend8x32(float32(x), float32(y), float32(spec)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vblend4x64(float64(x), float64(y), float64(spec)));
            else 
                throw unsupported<T>();
        }    


    }
}
