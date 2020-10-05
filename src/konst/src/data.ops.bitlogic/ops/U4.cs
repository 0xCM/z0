//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitLogic
    {
        [ApiHost(ApiNames.BitLogicU4, true)]
        public readonly struct U4
        {
            [MethodImpl(Inline), Op]
            public static uint4 @false(uint4 a, uint4 b)
                => uint4.Min;

            [MethodImpl(Inline), Op]
            public static uint4 @true(uint4 a, uint4 b)
                => uint4.Max;

            [MethodImpl(Inline), Op]
            public static uint4 and(uint4 a, uint4 b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static uint4 nand(uint4 a, uint4 b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static uint4 or(uint4 a, uint4 b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static uint4 nor(uint4 a, uint4 b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static uint4 xor(uint4 a, uint4 b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static uint4 xnor(uint4 a, uint4 b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static uint4 impl(uint4 a, uint4 b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static uint4 nonimpl(uint4 a, uint4 b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static uint4 left(uint4 a, uint4 b)
                => a;

            [MethodImpl(Inline), Op]
            public static uint4 right(uint4 a, uint4 b)
                => b;

            [MethodImpl(Inline), Op]
            public static uint4 lnot(uint4 a, uint4 b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static uint4 rnot(uint4 a, uint4 b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static uint4 cimpl(uint4 a, uint4 b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static uint4 cnonimpl(uint4 a, uint4 b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static uint4 same(uint4 a, uint4 b)
                => z.@byte(a == b);
        }
    }
}