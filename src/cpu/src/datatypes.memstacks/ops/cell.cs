//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class MemBlocks
    {
        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref MemBlock8 src, int index)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref MemBlock16 src, int index)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref MemBlock32 src, int index)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref MemBlock64 src, int index)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref MemBlock128 src, int index)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);
    }
}