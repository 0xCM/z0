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

    partial class XTend
    {
        /// <summary>
        /// Presents a 128-bit vector as a 128-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell128 ToFixed<T>(this in Vector128<T> x)
            where T : unmanaged
                => ref Cells.from(x);

        /// <summary>
        /// Presents a 256-bit vector as a 256-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell256 ToFixed<T>(this in Vector256<T> x)
            where T : unmanaged
                => ref Cells.from(x);

        /// <summary>
        /// Presents a 512-bit vector as a 512-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell512 ToFixed<T>(this in Vector512<T> x)
            where T : unmanaged
                => ref Cells.from(x);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 ToFixed<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => CellOps.vfix(f);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 ToFixed<T>(this Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => CellOps.vfix(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 ToFixed<T>(this Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => CellOps.vfix(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 ToFixed<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => CellOps.vfix(f);
    }
}