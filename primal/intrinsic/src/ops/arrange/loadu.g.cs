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
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static Vec128<T> loadu128<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return loadu128u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return loadu128i(in src);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<T> loadu256<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return loadu256u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return loadu256i(in src);
            else
                throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        static unsafe Vec128<T> loadu128u<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vloadu128(in uint8(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vloadu128(in uint16(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vloadu128(in uint32(in src)));
            else
                return generic<T>(dinx.vloadu128(in uint64(in src)));
        }
        
        [MethodImpl(Inline)]
        static unsafe Vec128<T> loadu128i<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vloadu128(in int8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vloadu128(in int16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vloadu128(in int32(in src)));
            else
                return generic<T>(dinx.vloadu128(in int64(in src)));
        }

        [MethodImpl(Inline)]
        static unsafe Vec256<T> loadu256u<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vloadu256(in uint8(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vloadu256(in uint16(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vloadu256(in uint32(in src)));
            else
                return generic<T>(dinx.vloadu256(in uint64(in src)));
        }
        
        [MethodImpl(Inline)]
        static unsafe Vec256<T> loadu256i<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vloadu256(in int8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vloadu256(in int16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vloadu256(in int32(in src)));
            else
                return generic<T>(dinx.vloadu256(in int64(in src)));
        }
    }
}
