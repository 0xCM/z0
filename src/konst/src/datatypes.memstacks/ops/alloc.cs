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

    partial class MemoryStacks
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
        public static BitBlock1024 alloc(W1024 w)
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

        [MethodImpl(Inline), Op]
        public static StackBlock1 alloc(W8 w, N1 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock2 alloc(W8 w, N2 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock3 alloc(W8 w, N3 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock4 alloc(W8 w, N4 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock5 alloc(W8 w, N5 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock6 alloc(W8 w, N6 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock7 alloc(W8 w, N7 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock8 alloc(W8 w, N8 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock9 alloc(W8 w, N9 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock10 alloc(W8 w, N10 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock11 alloc(W8 w, N11 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock12 alloc(W8 w, N12 n)
            => default;

        [MethodImpl(Inline), Op]
        public static StackBlock13 alloc(W8 w, N13 n)
            => default;

        /// <summary>
        /// Allocates a 14-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock14 alloc(W8 w, N14 n)
            => default;

        /// <summary>
        /// Allocates a 15-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock15 alloc(W8 w, N15 n)
            => default;

        /// <summary>
        /// Allocates a 16-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock16 alloc(W8 w, N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock32 alloc(W8 w, N32 n)
            => default;

        /// <summary>
        /// Allocates a 64-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock64 alloc(W8 w, N64 n)
            => default;

        /// <summary>
        /// Allocates a 128-byte block
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static StackBlock128 alloc(W8 w, N128 n)
            => default;

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out StackBlock8 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out StackBlock16 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out StackBlock32 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out StackBlock64 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        [MethodImpl(Inline), Op]
        public static ref byte alloc(out StackBlock128 dst)
        {
            dst = default;
            return ref u8(dst);
        }

        /// <summary>
        /// Allocates 2 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out StackBlock128 a, out StackBlock128 b)
        {
            a = default;
            b = default;
        }

        /// <summary>
        /// Allocates 3 128-byte blocks
        /// </summary>
        /// <param name="n">The byte-count selector</param>
        [MethodImpl(Inline), Op]
        public static void alloc(out StackBlock128 a, out StackBlock128 b, out StackBlock128 c)
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
        public static void alloc(out StackBlock128 a, out StackBlock128 b, out StackBlock128 c, out StackBlock128 d)
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