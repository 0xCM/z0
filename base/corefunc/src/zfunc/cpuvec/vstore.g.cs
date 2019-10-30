//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

using static zfunc;
using static Z0.As;
using static Z0.AsIn;
using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static void vstore<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore128_u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore128_i(src, ref dst);
        else 
            vstore128_f(src, ref dst);
    }

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore256_u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore256_i(src, ref dst);
        else 
            vstore256_f(src, ref dst);
    }

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
    static void vstore128_u<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(uint32(src), ref uint32(ref dst));
        else
            cpufunc.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128_i<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(int32(src), ref int32(ref dst));
        else
            cpufunc.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128_f<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore256_u<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(uint32(src), ref uint32(ref dst));
        else
            cpufunc.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256_i<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(int32(src), ref int32(ref dst));
        else
            cpufunc.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256_f<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore128_u<T>(Vector128<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(uint8(src), ref uint8(ref dst), offset);
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(uint16(src), ref uint16(ref dst), offset);
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(uint32(src), ref uint32(ref dst), offset);
        else
            cpufunc.vstore(uint64(src), ref uint64(ref dst), offset);
    }

    [MethodImpl(Inline)]
    static void vstore128_i<T>(Vector128<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(int8(src), ref int8(ref dst), offset);
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(int16(src), ref int16(ref dst), offset);
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(int32(src), ref int32(ref dst), offset);
        else
            cpufunc.vstore(int64(src), ref int64(ref dst), offset);
    }

    [MethodImpl(Inline)]
    static void vstore128_f<T>(Vector128<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(float32(src), ref float32(ref dst), offset);
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(float64(src), ref float64(ref dst), offset);
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore256_u<T>(Vector256<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(uint8(src), ref uint8(ref dst), offset);
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(uint16(src), ref uint16(ref dst), offset);
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(uint32(src), ref uint32(ref dst), offset);
        else
            cpufunc.vstore(uint64(src), ref uint64(ref dst), offset);
    }

    [MethodImpl(Inline)]
    static void vstore256_i<T>(Vector256<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(int8(src), ref int8(ref dst), offset);
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(int16(src), ref int16(ref dst), offset);
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(int32(src), ref int32(ref dst), offset);
        else
            cpufunc.vstore(int64(src), ref int64(ref dst), offset);
    }

    [MethodImpl(Inline)]
    static void vstore256_f<T>(Vector256<T> src, ref T dst, int offset)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(float32(src), ref float32(ref dst), offset);
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(float64(src), ref float64(ref dst), offset);
        else 
            throw unsupported<T>();                
    }
}