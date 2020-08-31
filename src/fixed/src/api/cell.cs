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

    partial class Fixed
    {
        /// <summary>
        /// Queries/manipulates a cell within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<F,T>(ref F src, int index)
            where F : unmanaged, IFixedCell
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<F,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within an 8-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static ref T cell<T>(ref FixedCell8 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<FixedCell8,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 16-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static ref T cell<T>(ref FixedCell16 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<FixedCell16,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 32-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static ref T cell<T>(ref Fixed32 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Fixed32,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 64-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref FixedCell64 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<FixedCell64,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 128-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref FixedCell128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<FixedCell128,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 256-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref FixedCell256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<FixedCell256,T>(ref src), index);
    }
}