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

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint1 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint1,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint2 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint2,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint3 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint3,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint4 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint4,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint5 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint5,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint6 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint6,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in uint7 src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<uint7,S>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S edit<S>(in octet src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<octet,S>(ref As.edit(src));
    }
}