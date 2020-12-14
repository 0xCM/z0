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

    using static Konst;
    using static z;

    public readonly struct ApiIndex
    {
        public static ApiIndexService service(IWfShell wf)
            => ApiIndexService.init(wf);
    }
}