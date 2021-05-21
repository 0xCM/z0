//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiPartExtracts
    {
        public ResolvedPart Part {get;}

        readonly Index<ApiHostExtracts> Hosts;

        [MethodImpl(Inline)]
        public ApiPartExtracts(ResolvedPart part, Index<ApiHostExtracts> hosts)
        {
            Part = part;
            Hosts = hosts;
        }

        public ReadOnlySpan<ApiHostExtracts> View
        {
            [MethodImpl(Inline)]
            get => Hosts.View;
        }

        public ApiPartExtracts Sort()
        {
            Hosts.Sort();
            return this;
        }
    }
}