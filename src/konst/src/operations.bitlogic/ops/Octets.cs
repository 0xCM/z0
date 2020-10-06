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
        [ApiHost(ApiNames.BitLogicO8)]
        public partial struct Octets
        {
            [MethodImpl(Inline), Op]
            public static octet @false(octet a, octet b)
                => octet.Min;

            [MethodImpl(Inline), Op]
            public static octet @true(octet a, octet b)
                => octet.Max;

            [MethodImpl(Inline), Op]
            public static octet and(octet a, octet b)
                => a & b;

            [MethodImpl(Inline), Op]
            public static octet nand(octet a, octet b)
                => ~(a & b);

            [MethodImpl(Inline), Op]
            public static octet or(octet a, octet b)
                => a | b;

            [MethodImpl(Inline), Op]
            public static octet nor(octet a, octet b)
                => ~(a | b);

            [MethodImpl(Inline), Op]
            public static octet xor(octet a, octet b)
                => a ^ b;

            [MethodImpl(Inline), Op]
            public static octet xnor(octet a, octet b)
                => ~(a ^ b);

            [MethodImpl(Inline), Op]
            public static octet impl(octet a, octet b)
                => a | ~b;

            [MethodImpl(Inline), Op]
            public static octet nonimpl(octet a, octet b)
                => ~a & b;

            [MethodImpl(Inline), Op]
            public static octet left(octet a, octet b)
                => a;

            [MethodImpl(Inline), Op]
            public static octet right(octet a, octet b)
                => b;

            [MethodImpl(Inline), Op]
            public static octet lnot(octet a, octet b)
                => ~a;

            [MethodImpl(Inline), Op]
            public static octet rnot(octet a, octet b)
                => ~b;

            [MethodImpl(Inline), Op]
            public static octet cimpl(octet a, octet b)
                => ~a | b;

            [MethodImpl(Inline), Op]
            public static octet cnonimpl(octet a, octet b)
                => a & ~b;

            [MethodImpl(Inline)]
            public static octet same(octet a, octet b)
                => z.@byte(a == b);
        }
    }
}