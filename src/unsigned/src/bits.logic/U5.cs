//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct UBits
    {
        [ApiHost(ApiNames.BitLogicU5, true)]
        public readonly struct U5
        {
            [MethodImpl(Inline), Op]
            public static uint5 @false(uint5 a, uint5 b)
                => uint5.Min;

            [MethodImpl(Inline), Op]
            public static uint5 @true(uint5 a, uint5 b)
                => uint5.Max;

            [MethodImpl(Inline), Op]
            public static uint5 and(uint5 a, uint5 b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static uint5 nand(uint5 a, uint5 b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static uint5 or(uint5 a, uint5 b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static uint5 nor(uint5 a, uint5 b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static uint5 xor(uint5 a, uint5 b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static uint5 xnor(uint5 a, uint5 b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static uint5 impl(uint5 a, uint5 b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static uint5 nonimpl(uint5 a, uint5 b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static uint5 left(uint5 a, uint5 b)
                => a;

            [MethodImpl(Inline), Op]
            public static uint5 right(uint5 a, uint5 b)
                => b;

            [MethodImpl(Inline), Op]
            public static uint5 lnot(uint5 a, uint5 b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static uint5 rnot(uint5 a, uint5 b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static uint5 cimpl(uint5 a, uint5 b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static uint5 cnonimpl(uint5 a, uint5 b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static uint5 same(uint5 a, uint5 b)
                => z.@byte(a == b);
        }
    }
}