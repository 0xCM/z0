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
        /// Covers a pointer-identified T-counted buffer with a span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="count">The number of bytes to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(T* pSrc, uint count)
            where T : unmanaged
                => CreateSpan(ref @ref<T>(pSrc), (int)count);

        /// <summary>
        /// Covers T-parametric content beginning at a specified address with a span
        /// </summary>
        /// <param name="address">The source address</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(MemoryAddress address, uint count)
            where T : unmanaged
                => cover<T>((T*)address, count); 
        
        /// <summary>
        /// Covers content beginning at a specified address with a bytespan
        /// </summary>
        /// <param name="location">The source address</param>
        /// <param name="size">The number of bytes to cover</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> cover(MemoryAddress location, uint size)
            => cover<byte>(location, size);

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
        /// Creates a span over a sequence of T-cells from a specified number of S-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The S-cell count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> cover<S,T>(in S src, uint tCount)
            => CreateSpan(ref edit<S,T>(src), (int)tCount);
    }
}