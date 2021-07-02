//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T view<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src, 1));

        /// <summary>
        /// Presents a readonly view of a memory segment beginning at a specified base covering a specified <typeparamref name='T'/> cell count
        /// </summary>
        /// <param name="src">The base adress</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, uint count)
            where T : struct
                => cover<T>(src.Ref<T>(), count);

        /// <summary>
        /// Covers a memory segment with a span
        /// </summary>
        /// <param name="src">The base address</param>
        /// <param name="size">The segment size, in bytes</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => cover<byte>(src, size);


        /// <summary>
        /// Creates memory view of specified size beginning at a specified base + offset
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="offset">The offset at which the view begins</param>
        /// <param name="size">The view size</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> view(MemoryAddress @base, ulong offset, ByteSize size)
            => cover<byte>(@base + offset, size);

        /// <summary>
        /// Presents a readonly S-reference as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));
    }
}