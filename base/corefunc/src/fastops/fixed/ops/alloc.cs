//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class Fixed
    {
        /// <summary>
        /// Allocates 8 bits = 1 byte of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed8 alloc(N8 n)
            => default;        

        /// <summary>
        /// Allocates 16 bits = 2 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates 32 bits = 4 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed32 alloc(N32 n)
            => default;

        /// <summary>
        /// Allocates 64 bits = 8 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed64 alloc(N64 n)
            => default;

        /// <summary>
        /// Allocates 128 bits = 16 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed128 alloc(N128 n)
            => default;

        /// <summary>
        /// Allocates 256 bits = 32 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed256 alloc(N256 n)
            => default;

        /// <summary>
        /// Allocates 512 bits = 64 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed512 alloc(N512 n)
            => default;

        /// <summary>
        /// Allocates 1024 bits = 128 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed1024 alloc(N1024 n)
            => default;

        /// <summary>
        /// Allocates 2048 bits = 256 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed2048 alloc(N2048 n)
            => default;

        /// <summary>
        /// Allocates 4096 bits = 512 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed4096 alloc(N4096 n)
            => default;
    }
}