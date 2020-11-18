//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Stacked;
    using static z;

    partial class Stacks
    {
        /// <summary>
        /// Stack allocates 8 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock8 alloc(W8 w)
            => default;

        /// <summary>
        /// Stack allocates 16 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock16 alloc(W16 w)
            => default;

        /// <summary>
        /// Stack allocates 32 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock32 alloc(W32 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock64 alloc(W64 w)
            => default;


        /// <summary>
        /// Stack allocates 16 bytes = 128 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock128 alloc(W128 w)
            => default;

        /// <summary>
        /// Stack allocates 32 bytes = 256-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock256 alloc(W256 w)
            => default;

        /// <summary>
        /// Stack allocates 64 bytes = 512-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline), Op]
        public static BitBlock512 alloc(W512 w)
            => default;

        /// <summary>
        /// Stack allocates 128 bytes = 1024-bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static BitStack1024 alloc(W1024 w)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock256 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out BitBlock512 dst)
        {
            dst = default;
            return ref u8(dst);
        }

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