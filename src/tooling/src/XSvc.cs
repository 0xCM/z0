//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Svc = Z0;

    public static partial class XSvc
    {
        public static ToolCatalog ToolCatalog(this IWfRuntime wf)
            => Svc.ToolCatalog.create(wf);
    }
}