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
        public static Vec128<T> vnot<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_128u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_128i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vnot<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_256u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_256i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> vnot_128u<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnot(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnot(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnot(uint32(src)));
            else
                return generic<T>(dinx.vnot(uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vnot_128i<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnot(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnot(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnot(int32(src)));
            else
                return generic<T>(dinx.vnot(int64(src)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vnot_256u<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnot(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnot(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnot(uint32(src)));
            else
                return generic<T>(dinx.vnot(uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vnot_256i<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnot(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnot(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnot(int32(src)));
            else
                return generic<T>(dinx.vnot(int64(src)));
        }

    }

}