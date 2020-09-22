//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct X86HostCode
    {
        public readonly ApiHostUri Host;

        public readonly TableSpan<ApiCodeBlock> Code;

        [MethodImpl(Inline)]
        public X86HostCode(ApiHostUri host, ApiCodeBlock[] code)
        {
            Host = host;
            Code = code;
        }
    }
}