//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class XSvc
    {
        [ServiceFactory]
        public static IPipeRunner PipeRunner(this IWfShell wf)
            => Pipes.runner(wf);
    }
}