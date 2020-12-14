//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartCodeIndexEntry
    {
        public ApiHostUri Host {get;}

        public ApiHostCodeBlocks Code {get;}

        [MethodImpl(Inline)]
        public PartCodeIndexEntry(ApiHostUri host, in ApiHostCodeBlocks code)
        {
            Host = host;
            Code = code;
        }
    }
}