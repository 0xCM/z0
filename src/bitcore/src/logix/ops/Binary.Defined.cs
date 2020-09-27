//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitLogix
    {
        [MethodImpl(Inline), Op]
        public static Bit32 @false(Bit32 a, Bit32 b)
            => Bit32.Off;

        [MethodImpl(Inline), Op]
        public static Bit32 @true(Bit32 a, Bit32 b)
            => Bit32.On;

        [MethodImpl(Inline), Op]
        public static Bit32 and(Bit32 a, Bit32 b)
            => a & b;

        [MethodImpl(Inline), Op]
        public static Bit32 nand(Bit32 a, Bit32 b)
            => !(a & b);

        [MethodImpl(Inline), Op]
        public static Bit32 or(Bit32 a, Bit32 b)
            => a | b;

        [MethodImpl(Inline), Op]
        public static Bit32 nor(Bit32 a, Bit32 b)
            => ~(a | b);

        [MethodImpl(Inline), Op]
        public static Bit32 xor(Bit32 a, Bit32 b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static Bit32 xnor(Bit32 a, Bit32 b)
            => !(a ^ b);

        [MethodImpl(Inline), Op]
        public static Bit32 impl(Bit32 a, Bit32 b)
            => a | ~b;

        [MethodImpl(Inline), Op]
        public static Bit32 nonimpl(Bit32 a, Bit32 b)
            => ~a & b;

        [MethodImpl(Inline), Op]
        public static Bit32 left(Bit32 a, Bit32 b)
            => a;

        [MethodImpl(Inline), Op]
        public static Bit32 right(Bit32 a, Bit32 b)
            => b;

        [MethodImpl(Inline), Op]
        public static Bit32 lnot(Bit32 a, Bit32 b)
            => !a;

        [MethodImpl(Inline), Op]
        public static Bit32 rnot(Bit32 a, Bit32 b)
            => ~b;

        [MethodImpl(Inline), Op]
        public static Bit32 cimpl(Bit32 a, Bit32 b)
            => ~a | b;

        [MethodImpl(Inline), Op]
        public static Bit32 cnonimpl(Bit32 a, Bit32 b)
            => a & ~b;

        [MethodImpl(Inline)]
        public static Bit32 same(Bit32 a, Bit32 b)
            => a == b;
    }
}