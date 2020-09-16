//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public partial struct BitStates
    {
        [MethodImpl(Inline), Op]
        public static uint2 @false(uint2 a, uint2 b)
            => uint2.Min;

        [MethodImpl(Inline), Op]
        public static uint2 @true(uint2 a, uint2 b)
            => uint2.Max;

        [MethodImpl(Inline), Op]
        public static uint2 and(uint2 a, uint2 b)
            => a & b;

        [MethodImpl(Inline), Op]
        public static uint2 nand(uint2 a, uint2 b)
            => ~(a & b);

        [MethodImpl(Inline), Op]
        public static uint2 or(uint2 a, uint2 b)
            => a | b;

        [MethodImpl(Inline), Op]
        public static uint2 nor(uint2 a, uint2 b)
            => ~(a | b);

        [MethodImpl(Inline), Op]
        public static uint2 xor(uint2 a, uint2 b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static uint2 xnor(uint2 a, uint2 b)
            => ~(a ^ b);

        [MethodImpl(Inline), Op]
        public static uint2 impl(uint2 a, uint2 b)
            => a | ~b;

        [MethodImpl(Inline), Op]
        public static uint2 nonimpl(uint2 a, uint2 b)
            => ~a & b;

        [MethodImpl(Inline), Op]
        public static uint2 left(uint2 a, uint2 b)
            => a;

        [MethodImpl(Inline), Op]
        public static uint2 right(uint2 a, uint2 b)
            => b;

        [MethodImpl(Inline), Op]
        public static uint2 lnot(uint2 a, uint2 b)
            => ~a;

        [MethodImpl(Inline), Op]
        public static uint2 rnot(uint2 a, uint2 b)
            => ~b;

        [MethodImpl(Inline), Op]
        public static uint2 cimpl(uint2 a, uint2 b)
            => ~a | b;

        [MethodImpl(Inline), Op]
        public static uint2 cnonimpl(uint2 a, uint2 b)
            => a & ~b;

        [MethodImpl(Inline)]
        public static uint2 same(uint2 a, uint2 b)
            => z.@byte(a == b);
    }
}