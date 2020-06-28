//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Roots
    {
        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<sbyte>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<byte>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<short>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<ushort>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<int>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<uint>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<long>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<ulong>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<float>,Vector512<T>>(ref edit(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> generic<T>(in Vector512<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<double>,Vector512<T>>(ref edit(in src));
    }
}