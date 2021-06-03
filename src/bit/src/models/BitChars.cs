//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;
    using K = BitCharKind;
    using D = BitChars.CharData;

    [ApiHost]
    public readonly partial struct BitChars
    {
        [MethodImpl(Inline), Op]
        public static BitChar from(bit src)
            => new BitChar(src.State ? BitCharKind.On : BitCharKind.Off);

        [MethodImpl(Inline), Op]
        public static char render(BitChar src)
            => (char)src.Kind;

        [MethodImpl(Inline), Op]
        public static ref readonly BitCharKind kind(BitCharIndex index)
            => ref skip(CharData.Kinds, (byte)index);

        [MethodImpl(Inline), Op]
        public static string text(N0 n)
            =>  D.Off;

        [MethodImpl(Inline), Op]
        public static string text(N1 n)
            =>  D.On;

        [MethodImpl(Inline), Op]
        public static string text(N2 n)
            =>  D.SectionSep;

        [MethodImpl(Inline), Op]
        public static string text(N3 n)
            =>  D.SegmentSep;

        [MethodImpl(Inline), Op]
        public static string text(N4 n)
            =>  D.LeftFence;

        [MethodImpl(Inline), Op]
        public static string text(N5 n)
            =>  D.RightFence;

        [MethodImpl(Inline), Op]
        public static string text(N6 n)
            =>  D.Space;

        [MethodImpl(Inline), Op]
        public static string format(BitChar src)
            => src.Kind switch {
                K.Off => text(n0),
                K.On => text(n1),
                K.SectionSep => text(n2),
                K.SegmentSep => text(n3),
                K.LeftFence => text(n4),
                K.RightFence=> text(n5),
                _ => CharText.Space
            };
    }
}