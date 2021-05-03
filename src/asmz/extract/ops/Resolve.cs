//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class ApiExtractor
    {
        ResolvedHost ResolveHost(IApiHost src)
            => Resolver.ResolveHost(src);

        ResolvedPart ResolvePart(IPart src)
            => Resolver.ResolvePart(src);

        Index<ResolvedPart> ResolveCatalog(IApiCatalog catalog)
            => Resolver.ResolveCatalog(catalog);
    }
}