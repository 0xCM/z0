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
    static void vstore128_u<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(vcast8u(src), ref As.uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(vcast16u(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(vcast32u(src), ref uint32(ref dst));
        else
            cpufunc.vstore(vcast64u(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128_i<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(vcast8i(src), ref As.int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(vcast16i(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(vcast32i(src), ref int32(ref dst));
        else
            cpufunc.vstore(vcast64i(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128_f<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(vcast32f(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(vcast64f(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore256_u<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpufunc.vstore(vcast8u(src), ref As.uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpufunc.vstore(vcast16u(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpufunc.vstore(vcast32u(src), ref uint32(ref dst));
        else
            cpufunc.vstore(vcast64u(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256_i<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpufunc.vstore(vcast8i(src), ref As.int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpufunc.vstore(vcast16i(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpufunc.vstore(vcast32i(src), ref int32(ref dst));
        else
            cpufunc.vstore(vcast64i(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256_f<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpufunc.vstore(vcast32f(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpufunc.vstore(vcast64f(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }


}