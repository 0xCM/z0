//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    /// Returns a 128-bit vector with all bits disabled
    /// </summary>
    /// <param name="w">The bitness selector</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vzero<T>(N128 w, T t = default)
        where T : unmanaged
            => default;

    /// <summary>
    /// Returns a 256-bit vector with all bits disabled
    /// </summary>
    /// <param name="w">The bitness selector</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vzero<T>(N256 w, T t = default)
        where T : unmanaged
            => default;

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int8
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<sbyte> v8i<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsSByte();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint8
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<byte> v8u<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsByte();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int16
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<short> v16i<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsInt16();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint16
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<ushort> v16u<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsUInt16();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<int> v32i<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsInt32();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<uint> v32u<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsUInt32();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<long> v64i<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsInt64();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<ulong> v64u<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsUInt64();


    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type float32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<float> v32f<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsSingle();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type float64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<double> v64f<T>(Vector128<T> x)
        where T : unmanaged
            => x.AsDouble();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int8
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<sbyte> v8i<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsSByte();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint8
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<byte> v8u<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsByte();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int16
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<short> v16i<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsInt16();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint16
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<ushort> v16u<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsUInt16();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<int> v32i<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsInt32();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<uint> v32u<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsUInt32();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type int64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<long> v64i<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsInt64();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type uint64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<ulong> v64u<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsUInt64();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type float32
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<float> v32f<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsSingle();

    /// <summary>
    /// Presents a generic cpu vector as a cpu vector with components of type float64
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <typeparam name="T">The source vector primal component type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<double> v64f<T>(Vector256<T> x)
        where T : unmanaged
            => x.AsDouble(); 

    /// <summary>
    /// Reinterprets a vector over S-cells as a vector over T-cells
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <param name="t">A target cell type representative</param>
    /// <typeparam name="S">The source cell type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]
    public static Vector128<T> vconvert<S,T>(Vector128<S> x, T t = default)
        where S : unmanaged
        where T : unmanaged
            => x.As<S,T>();

    /// <summary>
    /// Reinterprets a vector over S-cells as a vector over T-cells
    /// </summary>
    /// <param name="x">The source vector</param>
    /// <param name="t">A target cell type representative</param>
    /// <typeparam name="S">The source cell type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]
    public static Vector256<T> vconvert<S,T>(Vector256<S> x, T t = default)
        where S : unmanaged
        where T : unmanaged
            => x.As<S,T>();

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
            => gvec.vstore(src, ref dst);

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
            => gvec.vstore(src, ref dst);

    [MethodImpl(Inline)]
    public static Span<T> vstore<T>(Vector128<T> src, Span<T> dst)
        where T : unmanaged            
            => gvec.vstore(src, dst);

    [MethodImpl(Inline)]
    public static Span<T> vstore<T>(Vector256<T> src, Span<T> dst)
        where T : unmanaged            
            => gvec.vstore(src, dst);

    /// <summary>
    /// Extracts an index-identified component from the source vector
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static T vcell<T>(Vector128<T> src, int index)
        where T : unmanaged
            => gvec.vcell(src,index);

    /// <summary>
    /// Extracts an index-identified component from the source vector
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="index">The index of the component to extract</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static T vcell<T>(Vector256<T> src, int index)
        where T : unmanaged
            => gvec.vcell(src,index);

    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<W,T>(W w = default, T t = default)
        where W : unmanaged, ITypeNat
        where T : unmanaged
            => gvec.vcount<W,T>();

    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<T>(N128 w, T t = default)
        where T : unmanaged
            => gvec.vcount<T>(w);

    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<T>(N256 w, T t = default)
        where T : unmanaged
            => gvec.vcount<T>(w);
    
}