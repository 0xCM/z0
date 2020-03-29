//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Memories;

    partial class As
    {
        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<byte>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<short>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ushort>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<int>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<uint>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<long>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ulong>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<float>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<double>,Vector128<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<byte>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<short>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ushort>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<int>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<uint>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<long>,Vector256<T>>(ref refs.edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ulong>,Vector256<T>>(ref refs.edit(in src));
    }
}