//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        void ExtractParts(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var datasets = root.list<ApiHostDataset>();
            for(var i=0; i<count; i++)
            {
                ExtractPart(skip(src,i));
            }
        }

        void ExtractHosts(ApiHosts src)
        {
            var count = src.Count;
            if(count == 0)
                return;

            var hosts = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var resolved = ResolveHost(host);
                ExtractHost(resolved);
            }
        }

        void ExtractPartCatalogs(ReadOnlySpan<IApiPartCatalog> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ExtractPartCatalog(skip(src,i));
            }
        }

        void ExtractPartCatalog(IApiPartCatalog src)
        {
            var dst = Paths.PartDir(src.PartId);
            ExtractHosts(src.ApiHosts);
        }
    }
}