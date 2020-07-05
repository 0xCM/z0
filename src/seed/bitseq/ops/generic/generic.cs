//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S1 = uint1;
    using S2 = uint2;
    using S3 = uint3;
    using S4 = uint4;
    using S5 = uint5;
    using S6 = uint6;
    using S7 = uint7;
    using S8 = octet;

    using static As;

    partial class BitSeqG
    {
        [MethodImpl(Inline)]
        public static bool match<A,B>()
            => typeof(B) == typeof(A);

 
        [MethodImpl(Inline)]
        public static ref S1 uint1<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S1>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S2 uint2<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S2>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S3 uint3<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S3>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S4 uint4<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S4>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S5 uint5<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S5>(ref As.edit(src));
        
        [MethodImpl(Inline)]
        public static ref S6 uint6<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S6>(ref As.edit(src));
        [MethodImpl(Inline)]
        public static ref S7 uint7<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S7>(ref As.edit(src));

        [MethodImpl(Inline)]
        public static ref S8 uint8<S>(in S src)
            where S : unmanaged, IBitSeq<S>
                => ref @as<S,S8>(ref As.edit(src));        
    }
}