//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    using D = BitSeqData;

    partial class Bit
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint1> data(W1 w)
            => recover<byte,uint1>(D.W1);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint2> data(W2 w)
            => recover<byte,uint2>(D.W2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint3> data(W3 w)
            => recover<byte,uint3>(D.W3);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint4> data(W4 w)
             => recover<byte,uint4>(D.W4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint5> data(W5 w)
             => recover<byte,uint5>(D.W5);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint6> data(W6 w)
            => recover<byte,uint6>(D.W6);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<uint7> data(W7 w)
            => recover<byte,uint7>(D.W7);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<octet> data(W8 w)
             => recover<byte,octet>(D.W8);
    }
}