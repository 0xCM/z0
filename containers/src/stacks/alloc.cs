//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
    using static Stacked;
    using static P2K;
    
    partial class Stacks
    {
        /// <summary>
        /// Stack allocates 64 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline)]
        public static MemStack64 alloc(N64 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline)]
        public static MemStack64 alloc(P2x6 p2)
            => default;

        /// <summary>
        /// Stack allocates 16 bytes = 128 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack128 alloc(N128 w)
            => default;

        /// <summary>
        /// Stack allocates 16 bytes = 128 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack128 alloc(P2x7 p2)
            => default;

        /// <summary>
        /// Stack allocates 32 bytes = 256-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack256 alloc(N256 w)
            => default;

        /// <summary>
        /// Stack allocates 32 bytes = 256-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack256 alloc(P2x8 p2)
            => default;

        /// <summary>
        /// Stack allocates 64 bytes = 512-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack512 alloc(N512 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bytes = 512-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack512 alloc(P2x9 p2)
            => default;

        /// <summary>
        /// Stack allocates 128 bytes = 1024-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline)]
        public static MemStack1024 alloc(N1024 n)
            => default;


        /// <summary>
        /// Stack allocates 128 bytes = 1024-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline)]
        public static MemStack1024 alloc(P2x10 p2)
            => default;
    }
}