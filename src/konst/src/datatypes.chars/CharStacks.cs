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

    [ApiHost]
    public readonly partial struct CharStacks
    {
        /// <summary>
        /// Allocates a 2-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack2 alloc(N2 n)
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack4 alloc(N4 n)
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack8 alloc(N8 n)
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack32 alloc(N32 n)
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack64 alloc(N64 n)
            => default;

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
