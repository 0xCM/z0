//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static memory;
    using static ApiExtracts;

    partial class ApiExtractor
    {
        uint ExtractPart(in ResolvedPart src)
        {
            var hosts = src.Hosts.View;
            var count = (uint)hosts.Length;
            if(count == 0)
                return 0;

            var counter = 0u;

            var dst = Paths.PartDir(src.Part);
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var extracted = ExtractHostDatast(host);
                counter += extracted.Routines.Count;
                HostDatasets.Add(extracted);
            }
            return counter;
        }

        public uint ExtractPart(IPart src, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var buffer = root.list<ApiMember>();
            var catalog = ApiQuery.partcat(src);
            var types = catalog.ApiTypes;
            var hosts = catalog.ApiHosts;

            foreach(var type in types)
                counter += ExtractType(type, dst);

            foreach(var host in hosts)
                counter  += ExtractHost(host, dst);

            return counter;
        }


        public Index<ApiMemberExtract> ExtractResolvedPart(in ResolvedPart src)
        {
            var dst = root.list<ApiMemberExtract>();
            ExtractHosts(src.Hosts, dst);
            return dst.ToArray();
        }

    }
}