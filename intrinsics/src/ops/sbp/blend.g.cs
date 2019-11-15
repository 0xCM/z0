//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        public static Vector256<T> vblend32x8<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vblend32x8_u(x, y, spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vblend32x8_i(x, y, spec);
            else 
                throw unsupported<T>();

        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend32x8_u<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vblend32x8(uint8(x), uint8(y), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vblend32x8(uint16(x), uint16(y), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vblend32x8(uint32(x), uint32(y), spec));
            else
                return generic<T>(dinx.vblend32x8(uint64(x), uint64(y), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vblend32x8_i<T>(Vector256<T> x, Vector256<T> y, Vector256<byte> spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vblend32x8(int8(x), int8(y), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vblend32x8(int16(x), int16(y), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vblend32x8(int32(x), int32(y), spec));
            else
                return generic<T>(dinx.vblend32x8(int64(x), int64(y), spec));
        }


    }
}