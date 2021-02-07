//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using U = uint7;

    partial struct UI
    {
        [ApiHost(ApiNames.U7, true)]
        public readonly struct U7
        {
            [MethodImpl(Inline), False]
            public static U @false(U a, U b)
                => U.Min;

            [MethodImpl(Inline), True]
            public static U @true(U a, U b)
                => U.Max;

            [MethodImpl(Inline), And]
            public static U and(U a, U b)
                => a & b;

            [MethodImpl(Inline), Nand]
            public static U nand(U a, U b)
                => ~(a & b);

            [MethodImpl(Inline), Or]
            public static U or(U a, U b)
                => a | b;

            [MethodImpl(Inline), Nor]
            public static U nor(U a, U b)
                => ~(a | b);

            [MethodImpl(Inline), Xor]
            public static U xor(U a, U b)
                => a ^ b;

            [MethodImpl(Inline), Xnor]
            public static U xnor(U a, U b)
                => ~(a ^ b);

            [MethodImpl(Inline), Impl]
            public static U impl(U a, U b)
                => a | ~b;

            [MethodImpl(Inline), NonImpl]
            public static U nonimpl(U a, U b)
                => ~a & b;

            [MethodImpl(Inline), Left]
            public static U left(U a, U b)
                => a;

            [MethodImpl(Inline), Right]
            public static U right(U a, U b)
                => b;

            [MethodImpl(Inline), LNot]
            public static U lnot(U a, U b)
                => ~a;

            [MethodImpl(Inline), RNot]
            public static U rnot(U a, U b)
                => ~b;

            [MethodImpl(Inline), CImpl]
            public static U cimpl(U a, U b)
                => ~a | b;

            [MethodImpl(Inline), CNonImpl]
            public static U cnonimpl(U a, U b)
                => a & ~b;

            [MethodImpl(Inline), Same]
            public static U same(U a, U b)
                => @byte(a == b);

            [MethodImpl(Inline), Select]
            public static U select(U a, U b, U c)
                => or(and(a,b), nonimpl(a,c));
        }
    }
}