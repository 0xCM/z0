//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    public readonly struct PartRoutinesProcessor
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        public static PartRoutinesProcessor service(IWfShell wf, ApiPartRoutines src)
            => new PartRoutinesProcessor(wf, WfShell.host(typeof(PartRoutinesProcessor)), src);

        public PartRoutinesProcessor(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Source = src;
        }

        public void Dispose()
        {

        }


        public void ProcessCalls()
            => EmitCallIndex.create(Source).Run(Wf);
    }
}