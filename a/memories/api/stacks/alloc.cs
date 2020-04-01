//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    
    using static Stacked;
    
    partial class Stacks
    {
        /// <summary>
        /// Stack allocates 8 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemStack8 alloc(W8 w)
            => default;

        /// <summary>
        /// Stack allocates 16 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemStack16 alloc(W16 w)
            => default;

        /// <summary>
        /// Stack allocates 32 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemStack32 alloc(W32 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemStack64 alloc(W64 w)
            => default;

        /// <summary>
        /// Stack allocates 16 bytes = 128 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static MemStack128 alloc(W128 w)
            => default;

        /// <summary>
        /// Stack allocates 32 bytes = 256-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static MemStack256 alloc(W256 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bytes = 512-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static MemStack512 alloc(W512 w)
            => default;

        /// <summary>
        /// Stack allocates 128 bytes = 1024-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemStack1024 alloc(W1024 w)
            => default;

       /// <summary>
       /// Allocates a 2-character storage stack
       /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack2 char2()
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack4 char4()
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack8 char8()
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack16 char16()
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack32 char32()
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack64 char64()
            => default; 
    }
}