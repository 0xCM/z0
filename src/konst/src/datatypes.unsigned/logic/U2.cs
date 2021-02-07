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

    using U = uint2;
    using api = UI;

    partial struct UI
    {
        [ApiHost(ApiNames.U2, true)]
        public readonly struct U2
        {
            [MethodImpl(Inline), False]
            public static U @false(U a, U b)
                => api.@false(a,b);

            [MethodImpl(Inline), True]
            public static U @true(U a, U b)
                => api.@true(a,b);

            [MethodImpl(Inline), And]
            public static U and(U a, U b)
                => api.and(a,b);

            [MethodImpl(Inline), Nand]
            public static U nand(U a, U b)
                => api.nand(a,b);

            [MethodImpl(Inline), Or]
            public static U or(U a, U b)
                => api.or(a,b);

            [MethodImpl(Inline), Nor]
            public static U nor(U a, U b)
                => api.nor(a,b);

            [MethodImpl(Inline), Xor]
            public static U xor(U a, U b)
                => api.xor(a,b);

            [MethodImpl(Inline), Xnor]
            public static U xnor(U a, U b)
                => api.xnor(a,b);

            [MethodImpl(Inline), Impl]
            public static U impl(U a, U b)
                => api.impl(a,b);

            [MethodImpl(Inline), NonImpl]
            public static U nonimpl(U a, U b)
                => api.nonimpl(a,b);

            [MethodImpl(Inline), Left]
            public static U left(U a, U b)
                => api.left(a,b);

            [MethodImpl(Inline), Right]
            public static U right(U a, U b)
                => api.right(a,b);

            [MethodImpl(Inline), LNot]
            public static U lnot(U a, U b)
                => api.lnot(a,b);

            [MethodImpl(Inline), RNot]
            public static U rnot(U a, U b)
                => api.rnot(a,b);

            [MethodImpl(Inline), CImpl]
            public static U cimpl(U a, U b)
                => api.cimpl(a,b);

            [MethodImpl(Inline), CNonImpl]
            public static U cnonimpl(U a, U b)
                => api.cnonimpl(a,b);

            [MethodImpl(Inline), Same]
            public static U same(U a, U b)
                => api.same(a,b);

            [MethodImpl(Inline), Select]
            public static U select(U a, U b, U c)
                => api.select(a,b,c);
        }
    }
}