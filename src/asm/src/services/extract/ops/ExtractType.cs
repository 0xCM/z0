//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static core;

    partial class ApiExtractor
    {
        // [Op]
        // public uint ExtractType(ApiCompleteType src, List<ApiMemberExtract> dst)
        // {
        //     var flow = Wf.Running(string.Format("Extracting type {0}", src.HostUri));
        //     var counter = 0u;
        //     var methods = @readonly(ApiQuery.methods(src, Exclusions));
        //     var count = methods.Length;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var method = ref skip(methods,i);
        //         var resolved = new ResolvedMethod(method, MemberUri(src.HostUri, method), ApiJit.jit(method));
        //         dst.Add(ApiExtracts.extract(resolved, Buffer));
        //         counter++;
        //     }

        //     Wf.Ran(flow, string.Format("Extracted {0} members from {1}", counter, src.HostUri));
        //     return counter;
        // }
    }
}