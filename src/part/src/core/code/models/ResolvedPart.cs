//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResolvedPart
    {
        public PartId Part {get;}

        public Index<ResolvedHost> Hosts {get;}

        [MethodImpl(Inline)]
        public ResolvedPart(PartId part, Index<ResolvedHost> hosts)
        {
            Part = part;
            Hosts = hosts;
        }
    }
}