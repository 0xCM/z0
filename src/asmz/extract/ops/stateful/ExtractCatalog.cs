//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiExtractor
    {
        ReadOnlySpan<ApiMemberExtract> ExtractCatalog(IApiCatalog src)
            => ExtractParts(Resolver.ResolveCatalog(src));

        uint ExtractCatalog(IApiPartCatalog src)
            => ExtractHosts(src.ApiHosts);
    }
}