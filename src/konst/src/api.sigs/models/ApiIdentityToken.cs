//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiIdentityToken : IApiToken<ApiIdentityToken,ulong>
    {
        public static ApiIdentityToken Empty => new ApiIdentityToken(0ul);

        internal readonly ulong Data;

        [MethodImpl(Inline)]
        internal ApiIdentityToken(ulong src)
            => Data = src;

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
}