//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class ApiExtractor
    {
        // public uint ExtractHosts(ReadOnlySpan<ResolvedHost> src, List<ApiMemberExtract> dst)
        // {
        //     var counter = 0u;
        //     var count = src.Length;
        //     for(var i=0; i<count; i++)
        //         counter += ExtractHost(skip(src,i), dst);
        //     return counter;
        // }

        uint ExtractHosts(ApiHosts src)
        {
            var count = src.Count;
            if(count == 0)
                return default;

            var counter =0u;
            var hosts = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var resolved = ResolveHost(host);
                var dataset = ExtractHostDatast(resolved);
                HostDatasets.Add(dataset);
                counter += dataset.HostBlockCount;
            }
            return (uint)count;
        }
    }
}