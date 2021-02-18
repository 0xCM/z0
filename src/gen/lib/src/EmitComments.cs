//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitComments : WfHost<EmitComments>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCommentsStep(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitCommentsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public EmitCommentsStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Wf.Created();
        }

        public void Run()
        {
            var flow = Wf.Running();
            ApiComments.collect(Wf);
            Wf.Ran(flow);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }
    }
}