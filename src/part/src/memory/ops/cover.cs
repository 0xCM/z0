//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct memory
    {
        /// <summary>
        /// Creates a span over a memory segment
        /// </summary>
        /// <param name="base">The segment base address</param>
        /// <param name="size">The length of the segment in byte</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<char> cover(string src)
            => cover<char>(pchar2(src), (uint)src.Length);

        /// <summary>
        /// Creates a <see cref='Span{T}'/> over a <typeparamref name='T'/> measured memory segment
        /// </summary>
        /// <param name="base">The segment base address</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(MemoryAddress @base, uint count)
            => cover<T>(@base.Pointer(), count);

        /// <summary>
        /// Creates a <see cref='Span{T}'/> over a <typeparamref name='T'/> measured memory segment sourced from a pointer
        /// </summary>
        /// <param name="pSrc">A pointer to the leading cell</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(void* pSrc, uint count)
            => cover(@as<T>(pSrc), count);

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
        /// Covers a pointer-identified T-counted buffer with a span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(T* pSrc, int count)
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

        /// <summary>
        /// Covers a reference-identified T-counted buffer with a span
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The number of T-cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cover<T>(in T src, ulong count)
            => CreateSpan(ref edit(src), (int)count);
    }
}