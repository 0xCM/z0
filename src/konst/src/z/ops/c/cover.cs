//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct z
    {
        /// <summary>
        /// Creates a T-counted T-span from an S-cell data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The T-counted target count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> cover<S,T>(in S src, uint count)
            => CreateSpan(ref edit<S,T>(src), (int)count);

        /// <summary>
        /// Covers T-parametric content beginning at a specified address with a span
        /// </summary>
        /// <param name="address">The source address</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(MemoryAddress address, uint count)
            where T : struct
                => CreateSpan<T>(ref address.Ref<T>(), (int)count);

        /// <summary>
        /// Covers content beginning at a specified address with a bytespan
        /// </summary>
        /// <param name="location">The source address</param>
        /// <param name="size">The number of bytes to cover</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> cover(MemoryAddress location, uint size)
            => cover<byte>(location, size);

        /// <summary>
        /// Covers a pointer-identified T-counted buffer with a span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(T* pSrc, uint count)
            where T : unmanaged
                => CreateSpan(ref @ref<T>(pSrc), (int)count);

        /// <summary>
        /// Covers a reference-identified T-counted buffer with a span
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The number of T-cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cover<T>(in T src, int count)
            => CreateSpan(ref edit(src), count);

        /// <summary>
        /// Covers a reference-identified T-counted buffer with a span
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The number of T-cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cover<T>(in T src, uint count)
            => CreateSpan(ref edit(src), (int)count);
    }
}