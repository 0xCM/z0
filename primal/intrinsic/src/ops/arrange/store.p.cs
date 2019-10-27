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



    }

}