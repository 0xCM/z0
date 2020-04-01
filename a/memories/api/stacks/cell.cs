//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Stacked;

    partial class Stacks
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref MemStack64 src, int index, T t = default)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref MemStack128 src, int index, T t = default)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);
            
        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref MemStack256 src, int index, T t = default)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref MemStack512 src, int index, T t = default)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates an index-identified generic cell value
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="index">The source index, relative to the cell type</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(ref MemStack1024 src, int index, T t = default)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack2 src, int index)
            => ref Unsafe.Add(ref head(ref src), index);

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
            => ref Unsafe.Add(ref head(ref src), index);

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