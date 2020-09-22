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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static ApiIdentityToken Tokenize(this OpIdentity src)
            => ApiIdentityTokens.dispense(src);
    }

    public readonly struct ApiIdentityToken : IApiToken<ApiIdentityToken,ulong>
    {
        internal readonly ulong Data;

        [MethodImpl(Inline)]
        internal ApiIdentityToken(ulong src)
        {
            Data = src;
        }

        public IdentityTargetKind TargetKind
            => IdentityTargetKind.Method;

        public string Identifier
            => ApiIdentityTokens.identity(this);

        [MethodImpl(Inline)]
        public int CompareTo(ulong src)
            => Data.CompareTo(src);

        [MethodImpl(Inline)]
        public bool Equals(ulong src)
            => Data == src;

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;
    }

    public readonly struct ApiIdentityTokens
    {
        static ConcurrentDictionary<ulong,OpIdentity> Index = new ConcurrentDictionary<ulong, OpIdentity>();

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
        static ulong key(OpIdentity src)
            => hash(src.Identifier);
    }
}