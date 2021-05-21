//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;

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

    }
}