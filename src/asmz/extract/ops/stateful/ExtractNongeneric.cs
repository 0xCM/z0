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
        uint ExtractNongeneric(IApiHost src, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var methods = @readonly(ApiQuery.nongeneric(src));
            var count = methods.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                var resolved = resolve(method, MemberUri(src.HostUri, method), ApiJit.jit(method));
                dst.Add(ApiExtracts.extract(resolved, Buffer));
                counter++;
            }
            return counter;
        }
    }
}