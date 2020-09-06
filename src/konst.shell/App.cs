//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    readonly struct App
    {
        public static int Main(params string[] args)
        {
            using var wf = Flow.shell(args);
            iter(wf.Modules.Files, m => wf.Raise(WfEvents.data(m, wf.Ct)));
            return 0;
        }
    }
}