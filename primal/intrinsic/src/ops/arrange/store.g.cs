//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;    
    using static As;
    

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static unsafe void vstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore_u(src,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore_i(src,ref dst);
            else 
                vstore_f(src,ref dst);
        }


        [MethodImpl(Inline)]
        public static unsafe void vstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore_u(src,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore_i(src,ref dst);
            else 
                vstore_f(src,ref dst);
        }


        [MethodImpl(Inline)]
        public static unsafe void vstore<T>(Vector128<T> src, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore_u(src,pDst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore_i(src,pDst);
            else 
                vstore_f(src,pDst);
        }

        [MethodImpl(Inline)]
        public static unsafe void vstore<T>(Vector256<T> src, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore_u(src,pDst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore_i(src,pDst);
            else 
                vstore_f(src,pDst);
        }

        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec128<T> src, ref T dst)
            where T : unmanaged
                => vstore(src.xmm, ref dst);

        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec256<T> src, ref T dst)
            where T : unmanaged
                => vstore(src.ymm, ref dst);
 

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector256<T> x, T* pDst)
            where T : unmanaged
        {
            Store((long*)pDst, int64(x));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector256<T> x, T* pDst)
            where T : unmanaged
        {
            Store((ulong*)pDst, uint64(x));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector256<T> x, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store((float*)pDst, float32(x));
            if(typeof(T) == typeof(double))
                Store((double*)pDst, float64(x));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> x, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Store((sbyte*)pDst, int8(x));
            if(typeof(T) == typeof(short))
                Store((short*)pDst, int16(x));
            if(typeof(T) == typeof(int))
                Store((int*)pDst, int32(x));
            else
                Store((long*)pDst, int64(x));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector128<T> x, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Store((byte*)pDst, uint8(x));
            if(typeof(T) == typeof(ushort))
                Store((ushort*)pDst, uint16(x));
            if(typeof(T) == typeof(uint))
                Store((uint*)pDst, uint32(x));
            else
                Store((ulong*)pDst, uint64(x));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector128<T> x, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store((float*)pDst, float32(x));
            if(typeof(T) == typeof(double))
                Store((double*)pDst, float64(x));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                zfunc.vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                zfunc.vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                zfunc.vstore(int32(src), ref int32(ref dst));
            else 
                zfunc.vstore(int64(src), ref int64(ref dst));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                zfunc.vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                zfunc.vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                zfunc.vstore(uint32(src), ref uint32(ref dst));
            else
                zfunc.vstore(uint64(src), ref uint64(ref dst));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                zfunc.vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                zfunc.vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                zfunc.vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                zfunc.vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                zfunc.vstore(int32(src), ref int32(ref dst));
            else 
                zfunc.vstore(int64(src), ref int64(ref dst));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                zfunc.vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                zfunc.vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                zfunc.vstore(uint32(src), ref uint32(ref dst));
            else
                zfunc.vstore(uint64(src), ref uint64(ref dst));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                zfunc.vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                zfunc.vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }
    }
}