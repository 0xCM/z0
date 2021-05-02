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

    partial class ByteBlocks
    {
        /// <summary>
        /// Stack allocates 8 bits of storage
        /// </summary>
        /// <param name="w">The storage width</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock1 block(N1 n)
            => default;

        /// <summary>
        /// Stack allocates 2 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock2 block(N2 n)
            => default;

        /// <summary>
        /// Allocates 3 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock3 block(N3 n)
            => default;

        /// <summary>
        /// Allocates 4 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock4 block(N4 n)
            => default;

        /// <summary>
        /// Allocates 5 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock5 block(N5 n)
            => default;

        /// <summary>
        /// Allocates 6 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock6 block(N6 n)
            => default;

        /// <summary>
        /// Allocates 7 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock7 block(N7 n)
            => default;

        /// <summary>
        /// Allocates 8 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock8 block(N8 n)
            => default;

        /// <summary>
        /// Allocates 9 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock9 block(N9 n)
            => default;

        /// <summary>
        /// Allocates 10 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock10 block(N10 n)
            => default;

        /// <summary>
        /// Allocates 11 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock11 block(N11 n)
            => default;

        /// <summary>
        /// Allocates 12 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock12 block(N12 n)
            => default;

        /// <summary>
        /// Allocates 13 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock13 block(N13 n)
            => default;

        /// <summary>
        /// Allocates 14 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock14 block(N14 n)
            => default;

        /// <summary>
        /// Allocates 15 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock15 block(N15 n)
            => default;

        /// <summary>
        /// Allocates 16 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock16 block(N16 n)
            => default;

        /// <summary>
        /// Allocates 16 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock17 block(N17 n)
            => default;

        /// <summary>
        /// Allocates 18 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock18 block(N18 n)
            => default;

        /// <summary>
        /// Allocates 24 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock24 block(N24 n)
            => default;

        /// <summary>
        /// Allocates 32 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock32 block(N32 n)
            => default;

        /// <summary>
        /// Allocates 64 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock64 block(N64 n)
            => default;

        /// <summary>
        /// Allocates 128 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static ByteBlock128 block(N128 n)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock1 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock2 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock4 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out ByteBlock128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        /// <summary>
        /// Allocates 2 16-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void blocks(out ByteBlock16 a, out ByteBlock16 b)
        {
            a = default;
            b = default;
        }

        /// <summary>
        /// Allocates 3 64-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void blocks(out ByteBlock64 a, out ByteBlock64 b, out ByteBlock64 c)
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
        public static void blocks(out ByteBlock128 a, out ByteBlock128 b, out ByteBlock128 c, out ByteBlock128 d)
        {
            a = default;
            b = default;
            c = default;
            d = default;
        }
    }
}