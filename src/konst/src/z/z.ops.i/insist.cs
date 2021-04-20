//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static void require(bool invariant, in Func<string> f)
        {
            if(!invariant)
                sys.@throw(f);
        }

        [Op]
        public static void require(bool invariant, [Caller] string caller = null)
        {
            if(!invariant)
                sys.@throw(AppErrors.InvariantFailure(caller));
        }

        [MethodImpl(Inline)]
        public static ulong insist<N>(ulong src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
        {
            root.require(nat64u<N>() == src,  $"The source value {src} does not match the required natural value {nat64u<N>()}", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static int insist<N>(int src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
                => (int)insist<N>((ulong)src, n, caller, file, line);

    }
}