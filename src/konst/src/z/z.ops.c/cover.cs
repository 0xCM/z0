//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        /// <summary>
        /// Covers T-parametric content beginning at a specified address with a span
        /// </summary>
        /// <param name="address">The source address</param>
        /// <param name="count">The number of cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(MemoryAddress src, uint count)
            => memory.cover<T>(src, count);

        /// <summary>
        /// Covers content beginning at a specified address with a bytespan
        /// </summary>
        /// <param name="location">The source address</param>
        /// <param name="size">The number of bytes to cover</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> cover(MemoryAddress location, uint size)
            => memory.cover<byte>(location, size);

        [MethodImpl(Inline)]
        public static Span<T> cover<S,T>(in S src, uint count)
            => memory.cover<S,T>(src, count);

        [MethodImpl(Inline)]
        public static unsafe Span<T> cover<T>(T* pSrc, uint count)
            where T : unmanaged
                => memory.cover(pSrc, count);

        [MethodImpl(Inline)]
        public static Span<T> cover<T>(in T src, int count)
            => memory.cover(src, count);

        [MethodImpl(Inline)]
        public static Span<T> cover<T>(in T src, uint count)
            => memory.cover(src, count);

        [MethodImpl(Inline)]
        public static Span<T> cover<T>(in T src, ulong count)
            => memory.cover(src, count);
    }
}