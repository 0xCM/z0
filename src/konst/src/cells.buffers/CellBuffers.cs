//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.CellBuffers, true)]
    public readonly struct CellBuffers
    {
        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static CellBuffers<F> alloc<F>(byte count)
            where F : unmanaged, IDataCell
                => new CellBuffers<F>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static CellBuffers<Cell128> alloc(W128 width, byte count)
            => new CellBuffers<Cell128>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static CellBuffers<Cell256> alloc(W256 width, byte count)
            => new CellBuffers<Cell256>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static CellBuffers<Cell512> alloc(W512 width, byte count)
            => new CellBuffers<Cell512>(count);
    }
}