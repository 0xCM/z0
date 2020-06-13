//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    readonly partial struct ByteBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock2 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock3 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock4 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock5 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock6 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock7 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock8 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock9 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock10 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock11 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock12 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock13 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock14 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock15 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock16 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock32 src)
            => ref u8ref(src);

        [MethodImpl(Inline), Op]
        public static ref byte u8r(in ByteBlock64 src)
            => ref u8ref(src);
    }
}