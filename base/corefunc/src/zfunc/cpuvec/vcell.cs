//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Extracts an index-identified component from the source vector
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static T vcell<T>(Vector128<T> src, int index)
        where T : unmanaged
            => src.GetElement(index);

    /// <summary>
    /// Sets an index-identified component to a specified value
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <param name="value">The new component value</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vcell<T>(Vector128<T> src, int index, T value)
        where T : unmanaged
            => src.WithElement(index,value);

    /// <summary>
    /// Extracts an index-identified component from the source vector
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static T vcell<T>(Vector256<T> src, int index)
        where T : unmanaged
            => src.GetElement(index);

    /// <summary>
    /// Sets an index-identified component to a specified value
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <param name="value">The new component value</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vcell<T>(Vector256<T> src, int index, T value)
        where T : unmanaged
            => src.WithElement(index,value);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static sbyte vcell8i<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v8i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static byte vcell8u<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v8u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static short vcell16i<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v16i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static ushort vcell16u<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v16u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcell32i<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v32i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static uint vcell32u<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v32u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static long vcell64i<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v64i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static ulong vcell64u<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v64u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static float vcell32f<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v32f(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static double vcell64f<T>(Vector128<T> x, int index)
        where T : unmanaged
            => v64f(x).GetElement(index);
        
    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static sbyte vcell8i<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v8i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static byte vcell8u<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v8u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static short vcell16i<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v16i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static ushort vcell16u<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v16u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcell32i<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v32i(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static uint vcell32u<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v32u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static ulong vcell64u<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v64u(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static float vcell32f<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v32f(x).GetElement(index);

    /// <summary>
    /// Extract an index-identified component of a reinterpreted vector
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static double vcell64f<T>(Vector256<T> x, int index)
        where T : unmanaged
            => v64f(x).GetElement(index);
}