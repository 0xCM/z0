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


        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vand_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vand_128i(x,y);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vand_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vand_256i(x,y);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vand_128u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vand_128i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vand(int64(x), int64(y)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vand_256u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vand_256i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vand(int64(x), int64(y)));
        }
    }
}
