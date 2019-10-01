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
        public static Vec128<T> vflip<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vflip128u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vflip128i(src);
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec256<T> vflip<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vflip256u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vflip256i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> vflip128u<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vflip(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vflip(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vflip(uint32(src)));
            else
                return generic<T>(dinx.vflip(uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vflip128i<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vflip(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vflip(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vflip(int32(src)));
            else
                return generic<T>(dinx.vflip(int64(src)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vflip256u<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vflip(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vflip(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vflip(uint32(src)));
            else
                return generic<T>(dinx.vflip(uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vflip256i<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vflip(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vflip(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vflip(int32(src)));
            else
                return generic<T>(dinx.vflip(int64(src)));
        }

    }

}