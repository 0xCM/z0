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

    [ApiHost]
    public readonly partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint1> bits(N1 n)
            => recover<byte,uint1>(W1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(N2 n)
            => recover<byte,uint2>(W2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(N3 n)
            => recover<byte,uint3>(W3);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint4> bits(N4 n)
             => recover<byte,uint4>(W4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint5> bits(N5 n)
             => recover<byte,uint5>(W5);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint6> bits(N6 n)
            => recover<byte,uint6>(W6);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint7> bits(N7 n)
            => recover<byte,uint7>(W7);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<eight> bits(N8 n)
             => recover<byte,eight>(W8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq1>> symvals(N1 n)
            => Bytes.cells<SymVal<BitSeq1>>(n2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq2>> symvals(N2 n)
            => Bytes.cells<SymVal<BitSeq2>>(n4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq3>> symvals(N3 n)
            => Bytes.cells<SymVal<BitSeq3>>(n8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq4>> symvals(N4 n)
            => Bytes.cells<SymVal<BitSeq4>>(n16);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq5>> symvals(N5 n)
            => Bytes.cells<SymVal<BitSeq5>>(n32);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq6>> symvals(N6 n)
            => Bytes.cells<SymVal<BitSeq6>>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq7>> symvals(N7 n)
            => Bytes.cells<SymVal<BitSeq7>>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<SymVal<BitSeq8>> symvals(N8 n)
            => Bytes.cells<SymVal<BitSeq8>>(n256);
    }
}