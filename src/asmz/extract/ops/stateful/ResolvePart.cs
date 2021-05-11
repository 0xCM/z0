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
        ResolvedPart ResolvePart(IPart src)
        {
            var resolved = Resolver.ResolvePart(src);
            Receivers.Raise(new PartResolvedEvent(resolved));
            return resolved;
        }
    }
}