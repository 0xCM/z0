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

        public readonly TableSpan<X86ApiCode> Code;

        [MethodImpl(Inline)]
        public X86HostCode(ApiHostUri host, X86ApiCode[] code)
        {
            Host = host;
            Code = code;
        }
    }
}