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
            where F : unmanaged, IFixed    
                => new BufferSeq<F>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<Fixed128> alloc(W128 width, byte count)
            => new BufferSeq<Fixed128>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<Fixed256> alloc(W256 width, byte count)
            => new BufferSeq<Fixed256>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline), Op]
        public static BufferSeq<Fixed512> alloc(W512 width, byte count)
            => new BufferSeq<Fixed512>(count);
    }
}