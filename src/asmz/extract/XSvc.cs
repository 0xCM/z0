//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;


    public static partial class XSvc
    {
        public static ApiExtractor ApiExtractor(this IWfRuntime wf)
            => Z0.ApiExtractor.create(wf);

        [Op]
        public static ApiResolver ApiResolver(this IWfRuntime wf)
            => Z0.ApiResolver.create(wf);

        public static Span<T> Sort<T>(this Span<T> src)
            where T : IComparable<T>
        {
            SpanSorter.sort(src);
            return src;
        }
    }
}