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
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<sbyte> x)
        where T : unmanaged
            => As.vgeneric<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<byte> x)
        where T : unmanaged
            => As.vgeneric<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<short> x)
        where T : unmanaged
            => As.vgeneric<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<ushort> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<int> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<uint> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<long> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<ulong> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<float> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vgeneric<T>(Vector128<double> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<sbyte> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<byte> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<short> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<ushort> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<int> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<uint> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<long> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<ulong> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]    
    public static Vector256<T> vgeneric<T>(Vector256<float> x)
        where T : unmanaged
            => As.generic<T>(x);

    /// <summary>
    /// Presents a cpu vector closed over a specified type as a generic cpu vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vgeneric<T>(Vector256<double> x)
        where T : unmanaged
            => As.generic<T>(x);
}