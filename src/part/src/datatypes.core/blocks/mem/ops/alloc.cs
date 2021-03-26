//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class MemBlocks
    {
        /// <summary>
        /// Stack allocates 8 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static MemBlock1 alloc(N1 n)
            => default;

        /// <summary>
        /// Stack allocates 2 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock2 alloc(N2 n)
            => default;

        /// <summary>
        /// Allocates 3 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock3 alloc(N3 n)
            => default;

        /// <summary>
        /// Allocates 4 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock4 alloc(N4 n)
            => default;

        /// <summary>
        /// Allocates 5 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock5 alloc(N5 n)
            => default;

        /// <summary>
        /// Allocates 6 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock6 alloc(N6 n)
            => default;

        /// <summary>
        /// Allocates 7 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock7 alloc(N7 n)
            => default;

        /// <summary>
        /// Allocates 8 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock8 alloc(N8 n)
            => default;

        /// <summary>
        /// Allocates 9 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock9 alloc(N9 n)
            => default;

        /// <summary>
        /// Allocates 10 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock10 alloc(N10 n)
            => default;

        /// <summary>
        /// Allocates 11 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock11 alloc(N11 n)
            => default;

        /// <summary>
        /// Allocates 12 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock12 alloc(N12 n)
            => default;

        /// <summary>
        /// Allocates 13 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock13 alloc(N13 n)
            => default;

        /// <summary>
        /// Allocates 14 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock14 alloc(N14 n)
            => default;

        /// <summary>
        /// Allocates 15 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock15 alloc(N15 n)
            => default;

        /// <summary>
        /// Allocates 16 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates 32 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock32 alloc(N32 n)
            => default;

        /// <summary>
        /// Allocates 64 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock64 alloc(N64 n)
            => default;

        /// <summary>
        /// Allocates 128 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static MemBlock128 alloc(N128 n)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock1 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock2 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock4 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out MemBlock128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        /// <summary>
        /// Allocates 2 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out MemBlock16 a, out MemBlock16 b)
        {
            a = default;
            b = default;
        }

        /// <summary>
        /// Allocates 3 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out MemBlock64 a, out MemBlock64 b, out MemBlock64 c)
        {
            a = default;
            b = default;
            c = default;
        }

        /// <summary>
        /// Allocates 4 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out MemBlock128 a, out MemBlock128 b, out MemBlock128 c, out MemBlock128 d)
        {
            a = default;
            b = default;
            c = default;
            d = default;
        }
    }
}