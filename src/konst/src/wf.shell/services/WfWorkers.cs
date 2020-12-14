//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct WfWorkers : IWfService<WfWorkers,WfWorkers>
    {
        WfHost Host;

        IWfShell Wf;

        [MethodImpl(Inline)]
        public void Init(IWfShell wf)
        {
            Host = WfShell.host(typeof(WfWorkers));
            Wf = wf.WithHost(Host);
        }

        public void Run()
        {

        }
    }
}