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

    [ApiHost(ApiNames.BitSeq, true)]
    public readonly partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint1> bits(W1 w)
            => recover<byte,uint1>(W1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(W2 w)
            => recover<byte,uint2>(W2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(W2 w, N1 count)
            => slice(bits(w), 1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(W2 w, N2 count)
            => slice(bits(w), 2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(W2 w, N3 count)
            => slice(bits(w), 3);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> bits(W2 w, N4 count)
            => slice(bits(w), 4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(W3 w)
            => recover<byte,uint3>(W3);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(W3 w, N1 count)
            => slice(bits(w), 1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(W3 w, N2 count)
            => slice(bits(w), 2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(W3 w, N3 count)
            => slice(bits(w), count.NatValue);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> bits(W3 w, N4 count)
            => slice(bits(w), nat8u(count));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint4> bits(W4 w)
             => recover<byte,uint4>(W4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint5> bits(W5 w)
             => recover<byte,uint5>(W5);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint6> bits(W6 w)
            => recover<byte,uint6>(W6);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint7> bits(W7 w)
            => recover<byte,uint7>(W7);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<octet> bits(W8 w)
             => recover<byte,octet>(W8);
    }
}