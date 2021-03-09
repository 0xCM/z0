//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq1>> sbits(N1 n)
            => Bytes.cells<Symbol<BitSeq1>>(n2);


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq2>> sbits(N2 n)
            => Bytes.cells<Symbol<BitSeq2>>(n4);


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq3>> sbits(N3 n)
            => Bytes.cells<Symbol<BitSeq3>>(n8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq4>> sbits(N4 n)
            => Bytes.cells<Symbol<BitSeq4>>(n16);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq5>> sbits(N5 n)
            => Bytes.cells<Symbol<BitSeq5>>(n32);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq6>> sbits(N6 n)
            => Bytes.cells<Symbol<BitSeq6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq7>> sbits(N7 n)
            => Bytes.cells<Symbol<BitSeq7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<BitSeq8>> sbits(N8 n)
            => Bytes.cells<Symbol<BitSeq8>>(n256);
    }
}