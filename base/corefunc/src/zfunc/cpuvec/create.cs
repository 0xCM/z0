//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]
    public static Vector128<T> cpuvec<T>(N128 n, Span<T> src)
        where T : unmanaged
            =>  vload(n128,src);

    [MethodImpl(Inline)]
    public static Vector128<T> cpuvec<T>(N128 n, ReadOnlySpan<T> src)
        where T : unmanaged
            =>  vload(n128,src);

    [MethodImpl(Inline)]
    public static Vector128<T> cpuvec<T>(Span128<T> src)
        where T : unmanaged
            =>  vload(n128,src.Unblocked);

    [MethodImpl(Inline)]
    public static Vector128<T> cpuvec<T>(ReadOnlySpan128<T> src)
        where T : unmanaged
            =>  vload(n128,src.Unblocked);

    [MethodImpl(Inline)]
    public static Vector256<T> cpuvec<T>(N256 n, Span<T> src)
        where T : unmanaged
            =>  vload(n256,src);

    [MethodImpl(Inline)]
    public static Vector256<T> cpuvec<T>(N256 n, ReadOnlySpan<T> src)
        where T : unmanaged
            =>  vload(n256,src);

    [MethodImpl(Inline)]
    public static Vector256<T> cpuvec<T>(Span256<T> src)
        where T : unmanaged
            =>  vload(n256,src.Unblocked);

    [MethodImpl(Inline)]
    public static Vector256<T> cpuvec<T>(ReadOnlySpan256<T> src)
        where T : unmanaged
            =>  vload(n256,src.Unblocked);

    [MethodImpl(Inline)]
    public static Vector128<byte> cpuvec(
        byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
        byte x8, byte x9, byte xa, byte xb, byte xc, byte xd, byte xe, byte xf)
            => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7,x8,x9,xa,xb,xc,xd,xe,xf);

    [MethodImpl(Inline)]
    public static Vector128<ushort> cpuvec(ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
        => Vector128.Create(x0,x1, x2, x3, x4, x5, x6, x7);

    [MethodImpl(Inline)]
    public static Vector128<uint> cpuvec(uint x0, uint x1, uint x2, uint x3)
        => Vector128.Create(x0,x1, x2, x3);

    [MethodImpl(Inline)]
    public static Vector128<long> cpuvec(long x0, long x1)
        => Vector128.Create(x0,x1);

    [MethodImpl(Inline)]
    public static Vector128<ulong> cpuvec(ulong x0, ulong x1)
        => Vector128.Create(x0,x1);

    [MethodImpl(Inline)]
    public static Vector128<float> cpuvec(float x0, float x1, float x2, float x3)
        => Vector128.Create(x0,x1,x2,x3);

    [MethodImpl(Inline)]
    public static Vector128<double> cpuvec(double x0, double x1)
        => Vector128.Create(x0,x1);

    [MethodImpl(Inline)]
    public static Vector256<int> cpuvec(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

    [MethodImpl(Inline)]
    public static Vector256<uint> cpuvec(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
        => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

    [MethodImpl(Inline)]
    public static Vector256<long> cpuvec(long x0, long x1, long x2, long x3)
        => Vector256.Create(x0,x1,x2,x3);

    [MethodImpl(Inline)]
    public static Vector256<ulong> cpuvec(ulong x0, ulong x1, ulong x2, ulong x3)
        => Vector256.Create(x0,x1,x2,x3);

}
