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
        public static Block1 block(N1 n)
            => default;

        /// <summary>
        /// Stack allocates 2 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block2 block(N2 n)
            => default;

        /// <summary>
        /// Allocates 3 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block3 block(N3 n)
            => default;

        /// <summary>
        /// Allocates 4 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block4 block(N4 n)
            => default;

        /// <summary>
        /// Allocates 5 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block5 block(N5 n)
            => default;

        /// <summary>
        /// Allocates 6 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block6 block(N6 n)
            => default;

        /// <summary>
        /// Allocates 7 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block7 block(N7 n)
            => default;

        /// <summary>
        /// Allocates 8 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block8 block(N8 n)
            => default;

        /// <summary>
        /// Allocates 9 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block9 block(N9 n)
            => default;

        /// <summary>
        /// Allocates 10 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block10 block(N10 n)
            => default;

        /// <summary>
        /// Allocates 11 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block11 block(N11 n)
            => default;

        /// <summary>
        /// Allocates 12 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block12 block(N12 n)
            => default;

        /// <summary>
        /// Allocates 13 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block13 block(N13 n)
            => default;

        /// <summary>
        /// Allocates 14 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block14 block(N14 n)
            => default;

        /// <summary>
        /// Allocates 15 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block15 block(N15 n)
            => default;

        /// <summary>
        /// Allocates 16 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block16 block(N16 n)
            => default;

        /// <summary>
        /// Allocates 16 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block17 block(N17 n)
            => default;

        /// <summary>
        /// Allocates 18 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block18 block(N18 n)
            => default;

        /// <summary>
        /// Allocates 24 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block24 block(N24 n)
            => default;

        /// <summary>
        /// Allocates 32 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block32 block(N32 n)
            => default;

        /// <summary>
        /// Allocates 64 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block64 block(N64 n)
            => default;

        /// <summary>
        /// Allocates 128 bytes of storage
        /// </summary>
        /// <param name="n">The size selector</param>
        [MethodImpl(Inline), Op]
        public static Block128 block(N128 n)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block1 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block2 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block4 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte block(out Block128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        /// <summary>
        /// Allocates 2 16-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void blocks(out Block16 a, out Block16 b)
        {
            a = default;
            b = default;
        }

        /// <summary>
        /// Allocates 3 64-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void blocks(out Block64 a, out Block64 b, out Block64 c)
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
        public static void blocks(out Block128 a, out Block128 b, out Block128 c, out Block128 d)
        {
            a = default;
            b = default;
            c = default;
            d = default;
        }
    }
}