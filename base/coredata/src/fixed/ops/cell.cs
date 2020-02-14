//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class Fixed
    {
        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed512 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed1024 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed2048 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed4096 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);
    }
}