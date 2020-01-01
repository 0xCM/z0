//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static Stacked;

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
        /// Stack allocates 128 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack128 alloc(N128 w)
            => default;

        /// <summary>
        /// Stack allocates 256-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack256 alloc(N256 w)
            => default;

        /// <summary>
        /// Stack allocates 512-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static MemStack512 alloc(N512 w)
            => default;

        /// <summary>
        /// Stack allocates 1024-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline)]
        public static MemStack1024 alloc(N1024 n)
            => default;
    }
}