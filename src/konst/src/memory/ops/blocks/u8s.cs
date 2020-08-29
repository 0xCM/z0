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
    
    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock2 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock3 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock4 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock5 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock6 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock7 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock8 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock9 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock10 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock11 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock12 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock13 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock14 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock15 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock16 src)
            => span8u(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock32 src)
            => span8u(src);
    }
}