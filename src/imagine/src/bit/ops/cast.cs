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

    partial class Bit
    {
        [MethodImpl(Inline)]
        public static bool match<A,B>()
            => typeof(B) == typeof(A);

        [MethodImpl(Inline)]
        public static T cast2<S,T>(S src)
            => z.@as<S,T>(z.edit(src));

        [MethodImpl(Inline)]
        public static S cast<S>(byte src)
            where S : unmanaged, ISmallInt<S>
                => cast<byte,S>(src);

        [MethodImpl(Inline)]
        public static ref uint1 cast<S>(in S src, W1 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint1>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint2 cast<S>(in S src, W2 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint2>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint3 cast<S>(in S src, W3 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint3>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint4 cast<S>(in S src, W4 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint4>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint5 cast<S>(in S src, W5 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint5>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint5 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint5,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint6 cast<S>(in S src, W6 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint6>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref uint7 cast<S>(in S src, W7 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,uint7>(ref edit(src));
        
        [MethodImpl(Inline)]
        public static ref octet cast<S>(in S src, W8 dst)
            where S : unmanaged, ISmalInt<S,byte>
                => ref @as<S,octet>(ref edit(src));

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W1 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint1,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W2 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint2,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W3 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint3,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W4 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint4,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W5 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint5,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W6 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint6,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W7 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<uint7,S>(src);

        [MethodImpl(Inline)]
        public static S cast<S>(byte src, W8 dst)
            where S : unmanaged, ISmallInt<S>
                => cast2<octet,S>(src);                
        
        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint1 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint1,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint2 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint2,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint3 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint3,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint4 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint4,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint6 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint6,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in uint7 src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<uint7,S>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref S cast<S>(in octet src)
            where S : unmanaged, ISmallInt<S>
                => ref @as<octet,S>(ref edit(src));
    }
}