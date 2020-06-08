//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock2 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock3 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock4 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock5 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock6 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock7 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock8 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock9 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock10 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock11 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock12 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock13 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock14 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock15 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock16 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in CharBlock32 src)
            => ref u8ref(src);
    }
}