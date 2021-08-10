//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiExtractor
    {
        ReadOnlySpan<ApiCatalogEntry> EmitApiCatalog(Timestamp ts)
        {
            var dst = PackArchive.ApiCatalogPath();
            var members = ApiMembers.create(CollectedDatasets.SelectMany(x => x.Members));
            return Wf.ApiCatalogs().EmitApiCatalog(members, dst);
        }
    }
}