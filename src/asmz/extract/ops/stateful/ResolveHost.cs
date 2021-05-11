//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    using static memory;

    partial class ApiExtractor
    {
        ResolvedHost ResolveHost(IApiHost src)
        {
            var resolved = Resolver.ResolveHost(src);
            Receivers.Raise(new HostResolvedEvent(resolved));
            return resolved;
        }
    }
}