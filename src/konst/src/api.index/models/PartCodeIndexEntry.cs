//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct PartCodeIndexEntry
    {
        public ApiHostUri Host {get;}

        public ApiHostCode Code {get;}

        [MethodImpl(Inline)]
        public PartCodeIndexEntry(ApiHostUri host, in ApiHostCode code)
        {
            Host = host;
            Code = code;
        }
    }
}