//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;    

using Z0;
partial class zfunc
{
    [MethodImpl(Inline)]
    public static Block128<sbyte> block8i<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static Block128<byte> block8u<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static Block128<short> block16i<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,short>(src);

    [MethodImpl(Inline)]
    public static Block128<ushort> block16u<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,ushort>(src);

    [MethodImpl(Inline)]
    public static Block128<int> block32i<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,int>(src);

    [MethodImpl(Inline)]
    public static Block128<uint> block32u<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,uint>(src);

    [MethodImpl(Inline)]
    public static Block128<long> block64i<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,long>(src);

    [MethodImpl(Inline)]
    public static Block128<ulong> block64u<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,ulong>(src);

    [MethodImpl(Inline)]
    public static Block128<float> block32f<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,float>(src);

    [MethodImpl(Inline)]
    public static Block128<double> block64f<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,double>(src);

   [MethodImpl(Inline)]
    public static ConstBlock128<sbyte> block8i<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<byte> block8u<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<short> block16i<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,short>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<ushort> block16u<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,ushort>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<int> block32i<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,int>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<uint> block32u<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,uint>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<long> block64i<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,long>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<ulong> block64u<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,ulong>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<float> block32f<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,float>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<double> block64f<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,double>(src);

    [MethodImpl(Inline)]
    public static Block256<sbyte> block8i<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static Block256<byte> block8u<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static Block256<short> block16i<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,short>(src);

    [MethodImpl(Inline)]
    public static Block256<ushort> block16u<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,ushort>(src);

    [MethodImpl(Inline)]
    public static Block256<int> block32i<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,int>(src);

    [MethodImpl(Inline)]
    public static Block256<uint> block32u<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,uint>(src);

    [MethodImpl(Inline)]
    public static Block256<long> block64i<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,long>(src);

    [MethodImpl(Inline)]
    public static Block256<ulong> block64u<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,ulong>(src);

    [MethodImpl(Inline)]
    public static Block256<float> block32f<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,float>(src);

    [MethodImpl(Inline)]
    public static Block256<double> block64f<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,double>(src);

   [MethodImpl(Inline)]
    public static ConstBlock256<sbyte> block8i<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<byte> block8u<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<short> block16i<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,short>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<ushort> block16u<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,ushort>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<int> block32i<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,int>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<uint> block32u<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,uint>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<long> block64i<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,long>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<ulong> block64u<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,ulong>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<float> block32f<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,float>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<double> block64f<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,double>(src);
}