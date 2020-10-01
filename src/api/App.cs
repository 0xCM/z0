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
            using var wf = WfCore.shell(args);
            iter(wf.Modules.ManagedSources, m => wf.Raise(WfEvents.row(m, wf.Ct)));
            return 0;
        }
    }
}