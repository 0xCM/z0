//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static zfunc;    
    using static As;    

    partial class ginx
    {
        // [MethodImpl(Inline)]
        // public static unsafe void vstore<T>(Vector128<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte) 
        //     || typeof(T) == typeof(ushort) 
        //     || typeof(T) == typeof(uint) 
        //     || typeof(T) == typeof(ulong))
        //         vstore_u(src,ref dst);
        //     else if(typeof(T) == typeof(sbyte) 
        //     || typeof(T) == typeof(short) 
        //     || typeof(T) == typeof(int) 
        //     || typeof(T) == typeof(long))
        //         vstore_i(src,ref dst);
        //     else 
        //         vstore_f(src,ref dst);
        // }

        // [MethodImpl(Inline)]
        // public static unsafe void vstore<T>(Vector256<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte) 
        //     || typeof(T) == typeof(ushort) 
        //     || typeof(T) == typeof(uint) 
        //     || typeof(T) == typeof(ulong))
        //         vstore_u(src,ref dst);
        //     else if(typeof(T) == typeof(sbyte) 
        //     || typeof(T) == typeof(short) 
        //     || typeof(T) == typeof(int) 
        //     || typeof(T) == typeof(long))
        //         vstore_i(src,ref dst);
        //     else 
        //         vstore_f(src,ref dst);
        // }

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore128_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore128_i(src, ref dst, offset);
            else 
                vstore128_f(src, ref dst, offset);
        }

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore256_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore256_i(src, ref dst, offset);
            else 
                vstore256_f(src, ref dst, offset);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vstore(vcast8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.vstore(vcast16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.vstore(vcast32i(src), ref int32(ref dst));
            else 
                dinx.vstore(vcast64i(src), ref int64(ref dst));
        }

        // [MethodImpl(Inline)]
        // static unsafe void vstore_u<T>(Vector128<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte))
        //         dinx.vstore(vcast8u(src), ref uint8(ref dst));
        //     else if(typeof(T) == typeof(ushort))
        //         dinx.vstore(vcast16u(src), ref uint16(ref dst));
        //     else if(typeof(T) == typeof(uint))
        //         dinx.vstore(vcast32u(src), ref uint32(ref dst));
        //     else
        //         dinx.vstore(vcast64u(src), ref uint64(ref dst));
        // }

        // [MethodImpl(Inline)]
        // static unsafe void vstore_f<T>(Vector128<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(float))
        //         dinx.vstore(vcast32f(src), ref float32(ref dst));
        //     else if(typeof(T) == typeof(double))
        //         dinx.vstore(vcast64f(src), ref float64(ref dst));
        //     else 
        //         throw unsupported<T>();
        // }


        // [MethodImpl(Inline)]
        // static unsafe void vstore_i<T>(Vector256<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(sbyte))
        //         dinx.vstore(vcast8i(src), ref int8(ref dst));
        //     else if(typeof(T) == typeof(short))
        //         dinx.vstore(vcast16i(src), ref int16(ref dst));
        //     else if(typeof(T) == typeof(int))
        //         dinx.vstore(vcast32i(src), ref int32(ref dst));
        //     else 
        //         dinx.vstore(vcast64i(src), ref int64(ref dst));
        // }

        // [MethodImpl(Inline)]
        // static unsafe void vstore_u<T>(Vector256<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(byte))
        //         dinx.vstore(vcast8u(src), ref uint8(ref dst));
        //     else if(typeof(T) == typeof(ushort))
        //         dinx.vstore(vcast16u(src), ref uint16(ref dst));
        //     else if(typeof(T) == typeof(uint))
        //         dinx.vstore(vcast32u(src), ref uint32(ref dst));
        //     else
        //         dinx.vstore(vcast64u(src), ref uint64(ref dst));
        // }

        // [MethodImpl(Inline)]
        // static unsafe void vstore_f<T>(Vector256<T> src, ref T dst)
        //     where T : unmanaged
        // {
        //     if(typeof(T) == typeof(float))
        //         dinx.vstore(vcast32f(src), ref float32(ref dst));
        //     else if(typeof(T) == typeof(double))
        //         dinx.vstore(vcast64f(src), ref float64(ref dst));
        //     else 
        //         throw unsupported<T>();
        // }

        [MethodImpl(Inline)]
        static void vstore128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vstore(vcast8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                dinx.vstore(vcast16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                dinx.vstore(vcast32u(src), ref uint32(ref dst), offset);
            else
                dinx.vstore(vcast64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vstore(vcast8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                dinx.vstore(vcast16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                dinx.vstore(vcast32i(src), ref int32(ref dst), offset);
            else
                dinx.vstore(vcast64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dinx.vstore(vcast32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                dinx.vstore(vcast64f(src), ref float64(ref dst), offset);
            else 
                throw unsupported<T>();                
        }

        [MethodImpl(Inline)]
        static void vstore256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vstore(vcast8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                dinx.vstore(vcast16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                dinx.vstore(vcast32u(src), ref uint32(ref dst), offset);
            else
                dinx.vstore(vcast64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vstore(vcast8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                dinx.vstore(vcast16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                dinx.vstore(vcast32i(src), ref int32(ref dst), offset);
            else
                dinx.vstore(vcast64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dinx.vstore(vcast32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                dinx.vstore(vcast64f(src), ref float64(ref dst), offset);
            else 
                throw unsupported<T>();                
        }

    }
}