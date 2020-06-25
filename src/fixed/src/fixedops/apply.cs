//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class FixedOps    
    {
        /// <summary>
        /// Evaluates a 128-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        /// <summary>
        /// Evaluates a 256-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(UnaryOp256 f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        /// <summary>
        /// Evaluates a 512-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector512<T> apply<T>(UnaryOp512 f, in Vector512<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        /// <summary>
        /// Evaluates a 128-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> apply<T>(BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();

        /// <summary>
        /// Evaluates a 256-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> apply<T>(BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
 
        /// <summary>
        /// Evaluates a 512-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector512<T> apply<T>(BinaryOp512 f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>(); 
    }
}