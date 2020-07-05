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
        public static bool match<A,B>()
            => typeof(B) == typeof(A);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src)
            where S : unmanaged, IBitSeq<S>
                => cast<byte,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint1 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint1,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint2 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint2,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint3 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint3,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint4 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint4,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint5 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint5,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(uint6 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint6,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(in uint7 src)
            where S : unmanaged, IBitSeq<S>
                => cast<uint7,S>(src);

        [MethodImpl(Inline)]
        public static S generic<S>(octet src)
            where S : unmanaged, IBitSeq<S>
                => cast<octet,S>(src);

        [MethodImpl(Inline)]
        public static uint1 uint1<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint1>(src);

        [MethodImpl(Inline)]
        public static uint2 uint2<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint2>(src);

        [MethodImpl(Inline)]
        public static uint3 uint3<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint3>(src);

        [MethodImpl(Inline)]
        public static uint4 uint4<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint4>(src);

        [MethodImpl(Inline)]
        public static uint5 uint5<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint5>(src);

        [MethodImpl(Inline)]
        public static uint6 uint6<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint6>(src);

        [MethodImpl(Inline)]
        public static uint7 uint7<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,uint7>(src);
        
        [MethodImpl(Inline)]
        public static octet uint8<S>(S src)
            where S : unmanaged, IBitSeq<S,byte>
                => cast<S,octet>(src);
    }
}