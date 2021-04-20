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

    using static Part;
    using static memory;

    partial struct z
    {

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
            root.require(memory.nat64u<N>() == src,  $"The source value {src} does not match the required natural value {memory.nat64u<N>()}", caller, file, line);
            return src;
        }

        [MethodImpl(Inline)]
        public static int insist<N>(int src, N n = default, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
                => (int)insist<N>((ulong)src, n, caller, file, line);

    }
}