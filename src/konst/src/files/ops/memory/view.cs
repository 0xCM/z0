//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct MemoryFiles
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(MemoryAddress @base, ulong offset, ByteSize size)
            => memory.cover<byte>(@base + offset, size);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(in MemoryFile src)
            => memory.cover<byte>(src.BaseAddress, src.Size);

        /// <summary>
        /// Presents file content as a readonly sequence of <typeparamref name='T'/> cells
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in MemoryFile src)
            => memory.cover<T>(src.BaseAddress, src.Size/memory.size<T>());

        /// <summary>
        /// Presents file content segment as a readonly sequence of <typeparamref name='T'/> cells beginning
        /// at a <typeparamref name='T'/> measured offset and continuing to the end of the file
        /// </summary>
        /// <param name="tOffset">The number of cells to advance from the base address</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in MemoryFile src, uint tOffset)
            => memory.slice(view<T>(src), tOffset);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in MemoryFile src, uint tOffset, uint tCount)
            => memory.slice(view<T>(src), tOffset, tCount);
    }
}