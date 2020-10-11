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
        [ApiHost(ApiNames.BitLogicU7, true)]
        public readonly struct U7
        {
            [MethodImpl(Inline), Op]
            public static uint7 @false(uint7 a, uint7 b)
                => uint7.Min;

            [MethodImpl(Inline), Op]
            public static uint7 @true(uint7 a, uint7 b)
                => uint7.Max;

            [MethodImpl(Inline), Op]
            public static uint7 and(uint7 a, uint7 b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static uint7 nand(uint7 a, uint7 b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static uint7 or(uint7 a, uint7 b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static uint7 nor(uint7 a, uint7 b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static uint7 xor(uint7 a, uint7 b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static uint7 xnor(uint7 a, uint7 b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static uint7 impl(uint7 a, uint7 b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static uint7 nonimpl(uint7 a, uint7 b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static uint7 left(uint7 a, uint7 b)
                => a;

            [MethodImpl(Inline), Op]
            public static uint7 right(uint7 a, uint7 b)
                => b;

            [MethodImpl(Inline), Op]
            public static uint7 lnot(uint7 a, uint7 b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static uint7 rnot(uint7 a, uint7 b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static uint7 cimpl(uint7 a, uint7 b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static uint7 cnonimpl(uint7 a, uint7 b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static uint7 same(uint7 a, uint7 b)
                => z.@byte(a == b);
        }
    }
}