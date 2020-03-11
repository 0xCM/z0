//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public static class FixedBuffers
    {
        /// <summary>
        /// Allocates a bufer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<F> alloc<F>(int count)
            where F : unmanaged, IFixed    
                => new BufferSeq<F>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed128V> alloc(N128 width, int count)
            => new BufferSeq<Fixed128V>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed256V> alloc(N256 width, int count)
            => new BufferSeq<Fixed256V>(count);

        /// <summary>
        /// Allocates a bufer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static BufferSeq<Fixed512V> alloc(N512 width, int count)
            => new BufferSeq<Fixed512V>(count);
    }
}