//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Q = Z0;

    partial struct BitSeq
    {
        [MethodImpl(Inline)]
        static S cast<S>(byte src)
            where S : unmanaged, ISizedInt<S>
                => z.@as<byte,S>(src);

        [MethodImpl(Inline)]
        static S cast<S>(Limits24u src)
            where S : unmanaged, ISizedInt<S>
                => z.@as<Limits24u,S>(src);

        [MethodImpl(Inline)]
        static S maxval<S>()
            where S : unmanaged, ISizedInt<S>
        {
            if(typeof(S) == typeof(uint1))
                return cast<S>(Q.uint1.MaxLiteral);
            else if(typeof(S) == typeof(uint2))
                return cast<S>(Q.uint2.MaxLiteral);
            else if(typeof(S) == typeof(uint3))
                return cast<S>(Q.uint3.MaxLiteral);
            else if(typeof(S) == typeof(uint4))
                return cast<S>(Q.uint4.MaxLiteral);
            else
                return maxval<S>(z.w5);
        }

        [MethodImpl(Inline)]
        static S maxval<S>(W5 w5)
            where S : unmanaged, ISizedInt<S>
        {
            if(typeof(S) == typeof(uint5))
                return cast<S>(Q.uint5.MaxLiteral);
            else if(typeof(S) == typeof(uint6))
                return cast<S>(Q.uint6.MaxLiteral);
            else if(typeof(S) == typeof(uint7))
                return cast<S>(Q.uint7.MaxLiteral);
            else if(typeof(S) == typeof(uint8T))
                return cast<S>(Q.uint8T.MaxLiteral);
            else
                return maxval<S>(z.w16);
        }

        [MethodImpl(Inline)]
        static S maxval<S>(W16 w)
            where S : unmanaged, ISizedInt<S>
        {
            if(typeof(S) == typeof(uint24))
                return cast<S>(Q.uint24.MaxVal);
            else
                throw no<S>();
        }
    }
}