
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;

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
            Wf.Running();
            Comments.collect(Wf);
            Wf.Ran();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }
    }
}