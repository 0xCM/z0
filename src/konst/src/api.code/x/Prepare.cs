//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class XTend
    {
        public static ApiHexIndexer HexIndexer(this IWfShell wf)
            => ApiHexIndexer.create(wf);

        public static MethodInfo[] Prepare(this MethodInfo[] src)
        {
            var count = src.Length;
            ref readonly var method = ref first(src);
            for(var i=0; i<count; i++)
                ApiJit.jit(skip(method,i));
            return src;
        }
    }
}