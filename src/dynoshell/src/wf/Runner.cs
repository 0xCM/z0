//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    ref struct Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Runner(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(Runner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }


        public void EmitRuntimeIndex()
        {
            using var flow = Wf.Running();
            var cmd = Wf.CmdCatalog.EmitRuntimeIndex();
            //var worker = cmd.Worker();
            //var result  = worker.Invoke(Wf, cmd);
            //Wf.Status(result);

        }

        public void Run()
        {
            
        }
    }
}