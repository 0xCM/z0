//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    [ApiHost]
    public partial struct BitStates
    {
        [MethodImpl(Inline), Op]
        public static uint1 @false(uint1 a, uint1 b)
            => uint1.Min;

        [MethodImpl(Inline), Op]
        public static uint1 @true(uint1 a, uint1 b)
            => uint1.Max;

        [MethodImpl(Inline), Op]
        public static uint1 and(uint1 a, uint1 b)
            => a & b;

        [MethodImpl(Inline), Op]
        public static uint1 nand(uint1 a, uint1 b)
            => !(a & b);

        [MethodImpl(Inline), Op]
        public static uint1 or(uint1 a, uint1 b)
            => a | b;

        [MethodImpl(Inline), Op]
        public static uint1 nor(uint1 a, uint1 b)
            => ~(a | b);

        [MethodImpl(Inline), Op]
        public static uint1 xor(uint1 a, uint1 b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static uint1 xnor(uint1 a, uint1 b)
            => !(a ^ b);

        [MethodImpl(Inline), Op]
        public static uint1 impl(uint1 a, uint1 b)
            => a | ~b;

        [MethodImpl(Inline), Op]
        public static uint1 nonimpl(uint1 a, uint1 b)
            => ~a & b;

        [MethodImpl(Inline), Op]
        public static uint1 left(uint1 a, uint1 b)
            => a;

        [MethodImpl(Inline), Op]
        public static uint1 right(uint1 a, uint1 b)
            => b;

        [MethodImpl(Inline), Op]
        public static uint1 lnot(uint1 a, uint1 b)
            => !a;

        [MethodImpl(Inline), Op]
        public static uint1 rnot(uint1 a, uint1 b)
            => ~b;

        [MethodImpl(Inline), Op]
        public static uint1 cimpl(uint1 a, uint1 b)
            => ~a | b;

        [MethodImpl(Inline), Op]
        public static uint1 cnonimpl(uint1 a, uint1 b)
            => a & ~b;

        [MethodImpl(Inline)]
        public static uint1 same(uint1 a, uint1 b)
            => a == b;
    }
}