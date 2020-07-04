//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
 
    partial struct xHex
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex1Kind> src, Hex1Kind kind)
            => src.Chars((uint)kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex2Kind> src, Hex2Kind kind)
            => src.Chars((uint)kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex3Kind> src, Hex3Kind kind)
            => src.Chars((uint)kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex4Kind> src, Hex4Kind kind)
            => src.Chars((uint)kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex1Kind kind)
            => chars(text(n1), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex2Kind kind)
            => chars(text(n2), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex3Kind kind)
            => chars(text(n3), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex4Kind kind)
            => chars(text(n4), kind);
    }
}