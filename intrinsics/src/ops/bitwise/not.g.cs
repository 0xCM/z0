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
        public static Vector128<T> vnot<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_i(x);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnot<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_i(x);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnot(uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnot(uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnot(uint32(x)));
            else
                return generic<T>(dinx.vnot(uint64(x)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnot(int8(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnot(int16(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnot(int32(x)));
            else
                return generic<T>(dinx.vnot(int64(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnot(uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnot(uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnot(uint32(x)));
            else
                return generic<T>(dinx.vnot(uint64(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_i<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnot(int8(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnot(int16(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnot(int32(x)));
            else
                return generic<T>(dinx.vnot(int64(x)));
        }
    }
}