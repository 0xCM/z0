//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class ApiExtractor
    {
        public ReadOnlySpan<ApiMemberExtract> ExtractParts(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var counter = 0u;
            var flow = Wf.Running(Msg.ExtractingParts.Format(count));
            var dst = root.list<ApiMemberExtract>();
            for(var i=0; i<count; i++)
                counter += ExtractHosts(skip(src,i).Hosts, dst);
            Wf.Ran(flow, Msg.ExtractedParts.Format(counter,count));
            return dst.ViewDeposited();
        }
    }
}