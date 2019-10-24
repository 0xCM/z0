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
        public static void vloadu<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(in src, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vloadu_i(in src, out dst);
            else
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(in src, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                loadu_i(in src, out dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(pSrc, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vloadu_i(pSrc, out dst);
            else
                vloadu_f(pSrc, out dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(pSrc, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vloadu_i(pSrc, out dst);
            else
                vloadu_f(pSrc, out dst);
        }


        [MethodImpl(Inline)]
        static unsafe void vloadu_u<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(LoadDquVector256((byte*)pSrc));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(LoadDquVector256((ushort*)pSrc));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(LoadDquVector256((uint*)pSrc));
            else 
                dst = generic<T>(LoadDquVector256((ulong*)pSrc));

        }

        [MethodImpl(Inline)]
        static unsafe void vloadu_i<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadDquVector256((sbyte*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadDquVector256((short*)pSrc));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(LoadDquVector256((int*)pSrc));
            else 
                dst = generic<T>(LoadDquVector256((long*)pSrc));

        }

        [MethodImpl(Inline)]
        static unsafe void vloadu_f<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadVector256((float*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadVector256((double*)pSrc));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static unsafe void vloadu_u<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(LoadDquVector128((byte*)pSrc));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(LoadDquVector128((ushort*)pSrc));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(LoadDquVector128((uint*)pSrc));
            else 
                dst = generic<T>(LoadDquVector128((ulong*)pSrc));

        }

        [MethodImpl(Inline)]
        static unsafe void vloadu_i<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadDquVector128((sbyte*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadDquVector128((short*)pSrc));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(LoadDquVector128((int*)pSrc));
            else 
                dst = generic<T>(LoadDquVector128((long*)pSrc));

        }

        [MethodImpl(Inline)]
        static unsafe void vloadu_f<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadVector128((float*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadVector128((double*)pSrc));
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


        [MethodImpl(Inline)]
        static unsafe void vloadu_u<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(dinx.vloadu(uint8(src), out Vector128<byte> _));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(dinx.vloadu(uint16(src), out Vector128<ushort> _));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(dinx.vloadu(uint32(src), out Vector128<uint> _));
            else
                dst = generic<T>(dinx.vloadu(uint64(src), out Vector128<ulong> _));
        }
        
        [MethodImpl(Inline)]
        static unsafe void vloadu_i<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(dinx.vloadu(int8(src), out Vector128<sbyte> _));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(dinx.vloadu(int16(src), out Vector128<short> _));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(dinx.vloadu(int32(src), out Vector128<int> _));
            else
                dst = generic<T>(dinx.vloadu(int64(src), out Vector128<long> _));
        }

        [MethodImpl(Inline)]
        static unsafe void vloadu_u<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(dinx.vloadu(uint8(src), out Vector256<byte> _));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(dinx.vloadu(uint16(src), out Vector256<ushort> _));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(dinx.vloadu(uint32(src), out Vector256<uint> _));
            else
                dst = generic<T>(dinx.vloadu(uint64(src), out Vector256<ulong> _));
        }
        
        [MethodImpl(Inline)]
        static unsafe void loadu_i<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(dinx.vloadu(int8(src), out Vector256<sbyte> _));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(dinx.vloadu(int16(src), out Vector256<short> _));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(dinx.vloadu(int32(src), out Vector256<int> _));
            else
                dst = generic<T>(dinx.vloadu(int64(src), out Vector256<long> _));
        }

    }
}
