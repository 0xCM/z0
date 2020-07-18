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
        public static CellBlock1 alloc(N1 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock2 alloc(N2 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock3 alloc(N3 n)
            => default;
        
        [MethodImpl(Inline), Op]
        public static CellBlock4 alloc(N4 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock5 alloc(N5 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock6 alloc(N6 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock7 alloc(N7 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock8 alloc(N8 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock9 alloc(N9 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock10 alloc(N10 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock11 alloc(N11 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock12 alloc(N12 n)
            => default;

        [MethodImpl(Inline), Op]
        public static CellBlock13 alloc(N13 n)
            => default;

        /// <summary>
        /// Allocates a 14-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock14 alloc(N14 n)
            => default;

        /// <summary>
        /// Allocates a 15-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock15 alloc(N15 n)
            => default;

        /// <summary>
        /// Allocates a 16-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock32 alloc(N32 n)
            => default;       

        /// <summary>
        /// Allocates a 64-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock64 alloc(N64 n)
            => default;       

        /// <summary>
        /// Allocates a 128-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static CellBlock128 alloc(N128 n)
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
    }
}