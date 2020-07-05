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

    using S1 = uint1;
    using S2 = uint2;
    using S3 = uint3;
    using S4 = uint4;
    using S5 = uint5;
    using S6 = uint6;
    using S7 = uint7;
    using S8 = octet;

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static ref S edit<S>(in S1 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S1,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S2 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S2,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S3 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S3,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S4 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S4,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S5 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S5,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S6 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S6,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S7 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S7,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in S8 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S8,S>(ref As.edit(src));
    }
}