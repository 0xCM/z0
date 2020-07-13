//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IdentifiedCodeIndex
    {                
        public readonly ApiHostUri Host;

        public readonly IdentifiedCode[] Code;

        [MethodImpl(Inline)]
        public IdentifiedCodeIndex(ApiHostUri host, IdentifiedCode[] code)
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
        IdentifiedCodeIndex(IdentifiedCode[] code)
        {            
            Host = ApiHostUri.Empty;
            Code = code;
        }

        public static IdentifiedCodeIndex Empty 
            => new IdentifiedCodeIndex(sys.empty<IdentifiedCode>());
    }
}