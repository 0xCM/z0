//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public readonly struct ApiIdentityTokens
    {
        internal static ConcurrentDictionary<ulong,OpIdentity> Index = new ConcurrentDictionary<ulong, OpIdentity>();

        static OpIdentity Empty = OpIdentity.Empty;

        [MethodImpl(Inline)]
        public static ApiIdentityToken dispense(OpIdentity src)
        {
            var _key = key(src);
            Index.GetOrAdd(_key, k => src);
            return new ApiIdentityToken(_key);
        }

        [MethodImpl(Inline)]
        public static bool identity(ApiIdentityToken token, out OpIdentity dst)
            => Index.TryGetValue(token.Data, out dst);

        [MethodImpl(Inline)]
        public static OpIdentity identity(ApiIdentityToken token)
        {
            if(identity(token, out var dst))
                return dst;
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        internal static ulong key(in OpIdentity src)
            => hash(src.Identifier);
    }
}