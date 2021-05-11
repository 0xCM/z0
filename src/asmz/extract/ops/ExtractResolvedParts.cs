//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static memory;

    partial class ApiExtractor
    {
        public Index<ApiMemberExtract> ExtractResolvedParts(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var counter = 0u;
            var flow = Wf.Running(string.Format("Extracting {0} parts", count));
            var dst = root.list<ApiMemberExtract>();
            for(var i=0; i<count; i++)
                counter += ExtractHosts(skip(src,i).Hosts, dst);
            Wf.Ran(flow, string.Format("Extracted {0} methods from {1} parts", counter, count));
            return dst.ToArray();
        }
    }
}