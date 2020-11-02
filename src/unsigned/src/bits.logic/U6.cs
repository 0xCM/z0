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
        [ApiHost(ApiNames.BitLogicU6, true)]
        public readonly struct U6
        {
            [MethodImpl(Inline), Op]
            public static uint6 @false(uint6 a, uint6 b)
                => uint6.Min;

            [MethodImpl(Inline), Op]
            public static uint6 @true(uint6 a, uint6 b)
                => uint6.Max;

            [MethodImpl(Inline), Op]
            public static uint6 and(uint6 a, uint6 b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static uint6 nand(uint6 a, uint6 b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static uint6 or(uint6 a, uint6 b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static uint6 nor(uint6 a, uint6 b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static uint6 xor(uint6 a, uint6 b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static uint6 xnor(uint6 a, uint6 b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static uint6 impl(uint6 a, uint6 b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static uint6 nonimpl(uint6 a, uint6 b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static uint6 left(uint6 a, uint6 b)
                => a;

            [MethodImpl(Inline), Op]
            public static uint6 right(uint6 a, uint6 b)
                => b;

            [MethodImpl(Inline), Op]
            public static uint6 lnot(uint6 a, uint6 b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static uint6 rnot(uint6 a, uint6 b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static uint6 cimpl(uint6 a, uint6 b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static uint6 cnonimpl(uint6 a, uint6 b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static uint6 same(uint6 a, uint6 b)
                => z.@byte(a == b);
        }
    }
}