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
    public static Vector128<T> vload<T>(N128 n, Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return vload128_u(src);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return vload128_i(src);
        else 
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return vload128_u(src);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return vload128_i(src);
        else 
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    public static Vector256<T> vload<T>(N256 n, Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return vload256_u(src);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return vload256_i(src);
        else 
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong))
            return vload256_u(src);
        else if(typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long))
            return vload256_i(src);
        else 
            throw unsupported<T>();
    }

    [MethodImpl(Inline)]
    static Vector128<T> vload128_u<T>(Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return generic<T>(cpufunc.vload(n128, head(uint8(src))));
        else if(typeof(T) == typeof(ushort))
            return generic<T>(cpufunc.vload(n128, head(uint16(src))));
        else if(typeof(T) == typeof(uint))
            return generic<T>(cpufunc.vload(n128, head(uint32(src))));
        else
            return generic<T>(cpufunc.vload(n128, head(uint64(src))));
    }



    [MethodImpl(Inline)]
    static Vector128<T> vload128_i<T>(Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return generic<T>(cpufunc.vload(n128, head(int8(src))));
        else if(typeof(T) == typeof(short))
            return generic<T>(cpufunc.vload(n128, head(int16(src))));
        else if(typeof(T) == typeof(int))
            return generic<T>(cpufunc.vload(n128, head(int32(src))));
        else
            return generic<T>(cpufunc.vload(n128, head(int64(src))));
    }

    [MethodImpl(Inline)]
    static Vector128<T> vload128_u<T>(ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return generic<T>(cpufunc.vload(n128, head(uint8(src))));
        else if(typeof(T) == typeof(ushort))
            return generic<T>(cpufunc.vload(n128, head(uint16(src))));
        else if(typeof(T) == typeof(uint))
            return generic<T>(cpufunc.vload(n128, head(uint32(src))));
        else
            return generic<T>(cpufunc.vload(n128, head(uint64(src))));
    }

    [MethodImpl(Inline)]
    static Vector128<T> vload128_i<T>(ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return generic<T>(cpufunc.vload(n128, head(int8(src))));
        else if(typeof(T) == typeof(short))
            return generic<T>(cpufunc.vload(n128, head(int16(src))));
        else if(typeof(T) == typeof(int))
            return generic<T>(cpufunc.vload(n128, head(int32(src))));
        else
            return generic<T>(cpufunc.vload(n128, head(int64(src))));
    }

    [MethodImpl(Inline)]
    static Vector256<T> vload256_u<T>(Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return generic<T>(cpufunc.vload(n256, head(uint8(src))));
        else if(typeof(T) == typeof(ushort))
            return generic<T>(cpufunc.vload(n256, head(uint16(src))));
        else if(typeof(T) == typeof(uint))
            return generic<T>(cpufunc.vload(n256, head(uint32(src))));
        else
            return generic<T>(cpufunc.vload(n256, head(uint64(src))));
    }

    [MethodImpl(Inline)]
    static Vector256<T> vload256_i<T>(Span<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return generic<T>(cpufunc.vload(n256, head(int8(src))));
        else if(typeof(T) == typeof(short))
            return generic<T>(cpufunc.vload(n256, head(int16(src))));
        else if(typeof(T) == typeof(int))
            return generic<T>(cpufunc.vload(n256, head(int32(src))));
        else
            return generic<T>(cpufunc.vload(n256, head(int64(src))));
    }

    [MethodImpl(Inline)]
    static Vector256<T> vload256_u<T>(ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return generic<T>(cpufunc.vload(n256, head(uint8(src))));
        else if(typeof(T) == typeof(ushort))
            return generic<T>(cpufunc.vload(n256, head(uint16(src))));
        else if(typeof(T) == typeof(uint))
            return generic<T>(cpufunc.vload(n256, head(uint32(src))));
        else
            return generic<T>(cpufunc.vload(n256, head(uint64(src))));
    }

    [MethodImpl(Inline)]
    static Vector256<T> vload256_i<T>(ReadOnlySpan<T> src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return generic<T>(cpufunc.vload(n256, head(int8(src))));
        else if(typeof(T) == typeof(short))
            return generic<T>(cpufunc.vload(n256, head(int16(src))));
        else if(typeof(T) == typeof(int))
            return generic<T>(cpufunc.vload(n256, head(int32(src))));
        else
            return generic<T>(cpufunc.vload(n256, head(int64(src))));
    }


}

