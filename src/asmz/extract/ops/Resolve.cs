//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static ApiExtractReceivers;

    partial class ApiExtractor
    {
        ResolvedHost ResolveHost(IApiHost src)
        {
            var dst = Resolver.ResolveHost(src);
            Receivers.Raise(new HostResolvedEvent(dst));
            return dst;
        }

        ResolvedPart ResolvePart(IPart src)
            => Resolver.ResolvePart(src);

        Index<ResolvedPart> ResolveCatalog(IApiCatalog catalog)
            => Resolver.ResolveCatalog(catalog);
    }
}