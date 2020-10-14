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
            using var wf = WfShell.create(args);
            iter(wf.ApiParts.ManagedSources, m => wf.Raise(WfEvents.rows(m, wf.Ct)));
            return 0;
        }
    }
}