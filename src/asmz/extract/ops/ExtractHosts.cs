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
        public uint ExtractHosts(ReadOnlySpan<ResolvedHost> src, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
                counter += ExtractHost(skip(src,i), dst);
            return counter;
        }
    }
}