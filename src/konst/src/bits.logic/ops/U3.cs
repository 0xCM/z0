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
        [ApiHost(ApiNames.BitLogicU3)]
        public readonly struct U3
        {
            [MethodImpl(Inline), Op]
            public static uint3 @false(uint3 a, uint3 b)
                => uint3.Min;

            [MethodImpl(Inline), Op]
            public static uint3 @true(uint3 a, uint3 b)
                => uint3.Max;

            [MethodImpl(Inline), Op]
            public static uint3 and(uint3 a, uint3 b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static uint3 nand(uint3 a, uint3 b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static uint3 or(uint3 a, uint3 b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static uint3 nor(uint3 a, uint3 b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static uint3 xor(uint3 a, uint3 b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static uint3 xnor(uint3 a, uint3 b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static uint3 impl(uint3 a, uint3 b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static uint3 nonimpl(uint3 a, uint3 b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static uint3 left(uint3 a, uint3 b)
                => a;

            [MethodImpl(Inline), Op]
            public static uint3 right(uint3 a, uint3 b)
                => b;

            [MethodImpl(Inline), Op]
            public static uint3 lnot(uint3 a, uint3 b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static uint3 rnot(uint3 a, uint3 b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static uint3 cimpl(uint3 a, uint3 b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static uint3 cnonimpl(uint3 a, uint3 b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static uint3 same(uint3 a, uint3 b)
                => z.@byte(a == b);
        }

    }

}