//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using U = uint8T;

    partial struct UI
    {
        [ApiHost(ApiNames.BitLogicO8, true)]
        public readonly struct U8T
        {
            [MethodImpl(Inline), Op]
            public static U @false(U a, U b)
                => U.Min;

            [MethodImpl(Inline), Op]
            public static U @true(U a, U b)
                => U.Max;

            [MethodImpl(Inline), Op]
            public static U and(U a, U b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static U nand(U a, U b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static U or(U a, U b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static U nor(U a, U b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static U xor(U a, U b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static U xnor(U a, U b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static U impl(U a, U b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static U nonimpl(U a, U b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static U left(U a, U b)
                => a;

            [MethodImpl(Inline), Op]
            public static U right(U a, U b)
                => b;

            [MethodImpl(Inline), Op]
            public static U lnot(U a, U b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static U rnot(U a, U b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static U cimpl(U a, U b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static U cnonimpl(U a, U b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static U same(U a, U b)
                => z.@byte(a == b);
        }
    }
}