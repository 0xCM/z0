//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("buffers")]
    public readonly struct FixedBuffers
    {
        /// <summary>
        /// Allocates a bufer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<F> alloc<F>(byte count)
            where F : unmanaged, IFixedCell
                => new BufferSeq<F>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<FixedCell128> alloc(W128 width, byte count)
            => new BufferSeq<FixedCell128>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<FixedCell256> alloc(W256 width, byte count)
            => new BufferSeq<FixedCell256>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<FixedCell512> alloc(W512 width, byte count)
            => new BufferSeq<FixedCell512>(count);
    }
}