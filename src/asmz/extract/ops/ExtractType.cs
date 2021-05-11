//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Collections.Concurrent;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static ApiExtracts;

    partial class ApiExtractor
    {
        [Op]
        public uint ExtractType(ApiRuntimeType src, List<ApiMemberExtract> dst)
        {
            var flow = Wf.Running(string.Format("Extracting type {0}", src.HostUri));
            var counter = 0u;
            var methods = @readonly(ApiQuery.methods(src, Exclusions));
            var count = methods.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var resolved = resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method));
                dst.Add(extract(resolved, Buffer));
                counter++;
            }

            Wf.Ran(flow, string.Format("Extracted {0} members from {1}", counter, src.HostUri));
            return counter;
        }
    }
}