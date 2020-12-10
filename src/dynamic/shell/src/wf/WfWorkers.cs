//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;

    public struct WfWorkers : IWfService<WfWorkers>
    {
        WfHost Host;

        IWfShell Wf;

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(typeof(WfWorkers));
            Wf = wf.WithHost(Host);
        }
    }
}