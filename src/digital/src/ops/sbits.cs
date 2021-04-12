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
        public static ReadOnlySpan<SymVal<BitSeq1>> sbits(N1 n)
            => Bytes.cells<SymVal<BitSeq1>>(n2);


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq2>> sbits(N2 n)
            => Bytes.cells<SymVal<BitSeq2>>(n4);


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq3>> sbits(N3 n)
            => Bytes.cells<SymVal<BitSeq3>>(n8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq4>> sbits(N4 n)
            => Bytes.cells<SymVal<BitSeq4>>(n16);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq5>> sbits(N5 n)
            => Bytes.cells<SymVal<BitSeq5>>(n32);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq6>> sbits(N6 n)
            => Bytes.cells<SymVal<BitSeq6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq7>> sbits(N7 n)
            => Bytes.cells<SymVal<BitSeq7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq8>> sbits(N8 n)
            => Bytes.cells<SymVal<BitSeq8>>(n256);
    }
}