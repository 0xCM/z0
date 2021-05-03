//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using static memory;

    partial class ApiExtractor
    {
        ApiHostExtracts Extract(in ResolvedHost src)
            => Extractor.ExtractHost(src).Sort();

        ApiHostExtracts Extract(IApiHost src)
            => Extractor.ExtractHost(ResolveHost(src)).Sort();

        void ExtractCatalog(IApiCatalog src)
            => ExtractParts(ResolveCatalog(src));

        Index<ApiHostDataset> ExtractParts(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var datasets = root.list<ApiHostDataset>();
            for(var i=0; i<count; i++)
                ExtractPart(skip(src,i), datasets);
            return datasets.ToArray();
        }

        uint ExtractPart(in ResolvedPart src, List<ApiHostDataset> datasets)
        {
            var hosts = src.Hosts.View;
            var count = (uint)hosts.Length;
            if(count == 0)
                return 0;

            var counter = 0u;

            var dst = PartDir(src.Part);
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var extracted = ExtractHost(host);
                counter += extracted.Routines.Count;
                datasets.Add(extracted);
            }
            return counter;
        }

        ApiHostDataset ExtractHost(in ResolvedHost src)
        {
            var dst = new ApiHostDataset();
            dst.Resolution = src;
            var host = src.Host;
            var extracts = Extract(src);
            dst.HostExtracts = extracts;
            Emit(extracts.View, RawExtractPath(host));
            var parsed = Parse(extracts.View);
            dst.HostBlocks = parsed;
            Emit(parsed.View, ParsedExtractPath(host));
            var decoded = Decode(parsed.View);
            dst.Routines = decoded;
            Emit(decoded, AsmPath(host));
            return dst;
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
            var dst = PartDir(src.PartId);
            ExtractHosts(src.ApiHosts);
        }
    }
}