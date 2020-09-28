//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    readonly partial struct CellBlocks
    {
        [MethodImpl(Inline), Op]
        public static CellBlock1 alloc(W8 w, N1 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock2 alloc(W8 w, N2 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock3 alloc(W8 w, N3 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock4 alloc(W8 w, N4 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock5 alloc(W8 w, N5 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock6 alloc(W8 w, N6 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock7 alloc(W8 w, N7 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock8 alloc(W8 w, N8 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock9 alloc(W8 w, N9 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock10 alloc(W8 w, N10 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock11 alloc(W8 w, N11 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock12 alloc(W8 w, N12 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock13 alloc(W8 w, N13 n)
            => default;

        /// <summary>
        /// Allocates a 14-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock14 alloc(W8 w, N14 n)
            => default;

        /// <summary>
        /// Allocates a 15-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock15 alloc(W8 w, N15 n)
            => default;

        /// <summary>
        /// Allocates a 16-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock16 alloc(W8 w, N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock32 alloc(W8 w, N32 n)
            => default;

        /// <summary>
        /// Allocates a 64-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock64 alloc(W8 w, N64 n)
            => default;

        /// <summary>
        /// Allocates a 128-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock128 alloc(W8 w, N128 n)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out CellBlock8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out CellBlock16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out CellBlock32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out CellBlock64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out CellBlock128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        /// <summary>
        /// Allocates 2 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out CellBlock128 a, out CellBlock128 b)
        {
            a = default;
            b = default;
        }

        /// <summary>
        /// Allocates 3 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out CellBlock128 a, out CellBlock128 b, out CellBlock128 c)
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
        public static void alloc(out CellBlock128 a, out CellBlock128 b, out CellBlock128 c, out CellBlock128 d)
        {
            a = default;
            b = default;
            c = default;
            d = default;
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock2 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock3 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock4 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock5 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock6 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock7 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock8 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock16 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock32 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref char alloc(out CharBlock64 dst)
        {
            dst = default;
            return ref c16(dst);
        }

        [MethodImpl(Inline), Op]
        public static void alloc(out CharBlock64 a, out CharBlock64 b)
        {
            a = default;
            b = default;
        }

        [MethodImpl(Inline), Op]
        public static void alloc(out CharBlock64 a, out CharBlock64 b, out CharBlock64 c)
        {
            a = default;
            b = default;
            c = default;
        }


        [MethodImpl(Inline), Op]
        public static void alloc(out CharBlock64 a, out CharBlock64 b, out CharBlock64 c, out CharBlock64 d)
        {
            a = default;
            b = default;
            c = default;
            d = default;
        }
    }
}