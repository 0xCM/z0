//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ApiCodeBlocks
    {
        public readonly ApiHostUri Host;

        public readonly TableSpan<ApiCodeBlock> Code;

        [MethodImpl(Inline)]
        public ApiCodeBlocks(ApiHostUri host, ApiCodeBlock[] code)
        {
            Host = host;
            Code = code;
        }
    }
}