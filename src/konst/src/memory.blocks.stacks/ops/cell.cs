//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class MemoryStacks
    {
        // ~ asm(value<T>)
        // ~ movxsd rax,edx
        // ~ lea rax, [rcx + rax * sizeof(T)]
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref BitBlock64 src, int index, T t = default)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref BitBlock128 src, int index, T t = default)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref BitBlock256 src, int index, T t = default)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref BitBlock512 src, int index, T t = default)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(ref BitBlock1024 src, int index, T t = default)
            where T : unmanaged
                => ref memory.add(head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack2 src, int index)
            => ref memory.add(head(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack4 src, int index)
            => ref Unsafe.Add(ref head(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack8 src, int index)
            => ref Unsafe.Add(ref head(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack16 src, int index)
            => ref memory.add(head(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack32 src, int index)
            => ref Unsafe.Add(ref head(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack64 src, int index)
            => ref Unsafe.Add(ref head(ref src), index);
    }
}