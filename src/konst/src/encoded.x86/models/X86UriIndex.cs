//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct X86UriIndex
    {
        public readonly ApiHostUri Host;

        public readonly X86UriHex[] Code;

        [MethodImpl(Inline)]
        public X86UriIndex(ApiHostUri host, X86UriHex[] code)
        {
            z.insist(host.IsNonEmpty, $"Empty host uri");
            Host = host;
            Code = code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsNonEmpty && Code != null && Code.Length != 0;
        }

        [MethodImpl(Inline)]
        public X86UriIndex(X86UriHex[] code)
        {
            Host = ApiHostUri.Empty;
            Code = code;
        }

        public static X86UriIndex Empty
            => new X86UriIndex(sys.empty<X86UriHex>());
    }
}