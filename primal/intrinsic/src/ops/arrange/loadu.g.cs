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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static As;
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {        

        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vloadu<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
                => ref vloadu(refptr(ref asRef(in src)), out dst);

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vloadu<T>(N128 n, in T src)
            where T : unmanaged                    
                => vloadu(refptr(ref asRef(in src)), out Vector128<T> _);
        
        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vloadu<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
                => ref vloadu(refptr(ref asRef(in src)), out dst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vloadu<T>(N256 n, in T src)
            where T : unmanaged
                => vloadu(refptr(ref asRef(in src)), out Vector256<T> _);

        [MethodImpl(Inline)]
        public static Vec128<T> vloadu128<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return loadu128_u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return loadu128_i(in src);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<T> vloadu256<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return loadu256_u(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return loadu256_i(in src);
            else
                throw unsupported<T>();
        }




        [MethodImpl(Inline)]
        static unsafe Vec128<T> loadu128_u<T>(in T src)
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
        static unsafe Vec128<T> loadu128_i<T>(in T src)
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
        static unsafe Vec256<T> loadu256_u<T>(in T src)
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
        static unsafe Vec256<T> loadu256_i<T>(in T src)
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
