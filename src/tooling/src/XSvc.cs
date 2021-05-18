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
        public static FilePipe FilePipe(this IWfRuntime wf)
            => Svc.FilePipe.create(wf);
    }
}