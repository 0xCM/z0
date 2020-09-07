//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiHexIndex
    {
        public readonly ApiHostUri Host;

        public readonly ApiHex[] Code;

        [MethodImpl(Inline)]
        public ApiHexIndex(ApiHostUri host, ApiHex[] code)
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
        public ApiHexIndex(ApiHex[] code)
        {
            Host = ApiHostUri.Empty;
            Code = code;
        }

        public static ApiHexIndex Empty
            => new ApiHexIndex(sys.empty<ApiHex>());
    }
}