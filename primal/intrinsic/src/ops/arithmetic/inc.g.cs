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
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vinc<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vincu(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinci(src);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vinc<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vincu(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinci(src);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vinci<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vinc(int8(lhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vinc(int16(lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vinc(int32(lhs)));
            else
                 return generic<T>(dinx.vinc(int64(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vincu<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vinc(uint8(lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vinc(uint16(lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vinc(uint32(lhs)));
            else 
                return generic<T>(dinx.vinc(uint64(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinci<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vinc(int8(lhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vinc(int16(lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vinc(int32(lhs)));
            else
                 return generic<T>(dinx.vinc(int64(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vincu<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vinc(uint8(lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vinc(uint16(lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vinc(uint32(lhs)));
            else 
                return generic<T>(dinx.vinc(uint64(lhs)));
        }

    }
}