//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct nfunc
    {

    }

    partial struct z
    {
        [MethodImpl(Inline)]
        public static sbyte nat8i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat8i(n);

        [MethodImpl(Inline)]
        public static byte nat8u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat8u(n);

        [MethodImpl(Inline)]
        public static short nat16i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat16i(n);

        [MethodImpl(Inline)]
        public static ushort nat16u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat16u(n);

        [MethodImpl(Inline)]
        public static int nat32i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat32i(n);

        [MethodImpl(Inline)]
        public static uint nat32u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat32u(n);

        [MethodImpl(Inline)]
        public static ulong nat64u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat64u(n);

        [MethodImpl(Inline)]
        public static long nat64i<N>(N n = default)
            where N : unmanaged, ITypeNat
                => nfunc.nat64i(n);

        [MethodImpl(Inline)]
        public static T nat<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                 => nfunc.nat(n,t);

    }
}