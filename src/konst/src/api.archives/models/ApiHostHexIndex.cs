//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiHostHexIndex
    {
        public readonly ApiHostUri Host;

        public readonly ApiHex[] Code;

        [MethodImpl(Inline)]
        public ApiHostHexIndex(ApiHostUri host, ApiHex[] code)
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
        public ApiHostHexIndex(ApiHex[] code)
        {
            Host = ApiHostUri.Empty;
            Code = code;
        }

        public static ApiHostHexIndex Empty
            => new ApiHostHexIndex(sys.empty<ApiHex>());
    }
}