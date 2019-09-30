//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.Intrinsics.X86.Sse;
using static System.Runtime.Intrinsics.X86.Sse2;
using static System.Runtime.Intrinsics.X86.Avx;

using static zfunc;
using static Z0.As;
using static Z0.AsIn;
using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static void vstore<T>(in Vec128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore128u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore128i(src, ref dst);
        else 
            vstore128f(src, ref dst);
    }

    [MethodImpl(Inline)]
    public static void vstore<T>(in Vec256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore256u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore256i(src, ref dst);
        else 
            vstore256f(src, ref dst);
    }

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore128u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore128i(src, ref dst);
        else 
            vstore128f(src, ref dst);
    }

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            vstore256u(src, ref dst);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            vstore256i(src, ref dst);
        else 
            vstore256f(src, ref dst);
    }


    [MethodImpl(Inline)]
    static void vstore128u<T>(in Vec128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpuvec.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpuvec.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpuvec.vstore(uint32(src), ref uint32(ref dst));
        else
            cpuvec.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128i<T>(in Vec128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpuvec.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpuvec.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpuvec.vstore(int32(src), ref int32(ref dst));
        else
            cpuvec.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128f<T>(in Vec128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpuvec.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpuvec.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore256u<T>(in Vec256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpuvec.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpuvec.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpuvec.vstore(uint32(src), ref uint32(ref dst));
        else
            cpuvec.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256i<T>(in Vec256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpuvec.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpuvec.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpuvec.vstore(int32(src), ref int32(ref dst));
        else
            cpuvec.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256f<T>(in Vec256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpuvec.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpuvec.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }


    [MethodImpl(Inline)]
    static void vstore128u<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpuvec.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpuvec.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpuvec.vstore(uint32(src), ref uint32(ref dst));
        else
            cpuvec.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128i<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpuvec.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpuvec.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpuvec.vstore(int32(src), ref int32(ref dst));
        else
            cpuvec.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore128f<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpuvec.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpuvec.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

    [MethodImpl(Inline)]
    static void vstore256u<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            cpuvec.vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(ushort))
            cpuvec.vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(uint))
            cpuvec.vstore(uint32(src), ref uint32(ref dst));
        else
            cpuvec.vstore(uint64(src), ref uint64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256i<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            cpuvec.vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(short))
            cpuvec.vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(int))
            cpuvec.vstore(int32(src), ref int32(ref dst));
        else
            cpuvec.vstore(int64(src), ref int64(ref dst));
    }

    [MethodImpl(Inline)]
    static void vstore256f<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            cpuvec.vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            cpuvec.vstore(float64(src), ref float64(ref dst));
        else 
            throw unsupported<T>();                
    }

}

