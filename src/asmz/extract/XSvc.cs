//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static partial class XSvc
    {
        public static ApiExtractor ApiExtracor(this IWfRuntime wf)
            => Z0.ApiExtractor.create(wf);

        [Op]
        public static ApiResolver ApiResolver(this IWfRuntime wf)
            => Z0.ApiResolver.create(wf);
    }
}