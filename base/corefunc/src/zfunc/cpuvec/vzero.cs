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

   /// <summary>
    /// Creates a zero-filled 128-bit cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    /// <typeparam name="T">The vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vzero<T>(N128 n)
        where T : unmanaged
            => default;

    /// <summary>
    /// Creates a zero-filled 256-bit cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    /// <typeparam name="T">The vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vzero<T>(N256 n)
        where T : unmanaged
            => default;

    /// <summary>
    /// Creates a zero-filled 256x8i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<sbyte> vzero8i(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x8u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<byte> vzero8u(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x16i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<short> vzero16i(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x16u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<ushort> vzero16u(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x32i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<int> vzero32i(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x32u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<uint> vzero32u(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x64u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<long> vzero64i(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x64u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<ulong> vzero64u(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x32f cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<float> vzero32f(N256 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 256x64f cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector256<double> vzero64f(N256 n)
        => default;


    /// <summary>
    /// Creates a zero-filled 128x8i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<sbyte> vzero8i(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x8u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<byte> vzero8u(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x16i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<short> vzero16i(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x16u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<ushort> vzero16u(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x32i cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<int> vzero32i(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x32u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<uint> vzero32u(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x64u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<long> vzero64i(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x64u cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<ulong> vzero64u(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x32f cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<float> vzero32f(N128 n)
        => default;

    /// <summary>
    /// Creates a zero-filled 128x64f cpu vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    [MethodImpl(Inline)]
    public static Vector128<double> vzero64f(N128 n)
        => default;
}

