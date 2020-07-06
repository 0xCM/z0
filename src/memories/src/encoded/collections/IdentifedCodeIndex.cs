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
        public ApiHostUri Host {get;}

        public IdentifiedCode[] Code {get;}

        [MethodImpl(Inline)]
        public IdentifiedCodeIndex(ApiHostUri host, IdentifiedCode[] code)
        {
            Root.insist(host.IsNonEmpty);
            Host = host;
            Code = code;
        }

        [MethodImpl(Inline)]
        public IdentifiedCodeIndex(IdentifiedCode[] code)
        {            
            Host = ApiHostUri.Empty;
            Code = code;
        }

        public static IdentifiedCodeIndex Empty 
            => new IdentifiedCodeIndex(Array.Empty<IdentifiedCode>());
    }
}