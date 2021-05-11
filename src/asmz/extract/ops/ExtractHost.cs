//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Part;
    using static memory;
    using static ApiExtracts;

    partial class ApiExtractor
    {
        public ApiHostExtracts ExtractHost(in ResolvedHost src)
        {
            var dst = root.list<ApiMemberExtract>();
            ExtractHost(src,dst);
            return new ApiHostExtracts(src.Host, dst.ToArray());
        }

        public uint ExtractHost(IApiHost src, List<ApiMemberExtract> dst)
        {
            var flow = Wf.Running(string.Format("Extracting {0} members", src.HostUri));
            var counter = 0u;
            counter += ExtractNongeneric(src, dst);
            counter += ExtractGeneric(src,dst);
            Wf.Ran(flow,string.Format("Extracted {0} members from {1}", counter, src));
            return counter;
        }

        public uint ExtractHost(ResolvedHost src, List<ApiMemberExtract> dst)
        {
            var methods = src.Methods.View;
            var count = methods.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                dst.Add(extract(skip(methods,i), Buffer));
                counter++;
            }
            return counter;
        }
    }
}