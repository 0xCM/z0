//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Seed;

    partial class Vectors
    {
        /// <summary>
        /// Reinterprets a vector over S-cells as a vector over T-cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vto<S,T>(Vector128<S> x, T t = default)
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
        public static Vector256<T> vto<S,T>(Vector256<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<S,T>();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<sbyte> v8i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsSByte();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<byte> v8u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsByte();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<short> v16i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsInt16();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<ushort> v16u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsUInt16();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<int> v32i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsInt32();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<uint> v32u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsUInt32();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<long> v64i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsInt64();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<ulong> v64u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsUInt64();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type float32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<float> v32f<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsSingle();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type float64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<double> v64f<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsDouble();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<sbyte> v8i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsSByte();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<byte> v8u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsByte();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<short> v16i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsInt16();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<ushort> v16u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsUInt16();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<int> v32i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsInt32();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<uint> v32u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsUInt32();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type int64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<long> v64i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsInt64();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<ulong> v64u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsUInt64();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type float32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<float> v32f<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsSingle();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type float64
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<double> v64f<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsDouble(); 

    }
}