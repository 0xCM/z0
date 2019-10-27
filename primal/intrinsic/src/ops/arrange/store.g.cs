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