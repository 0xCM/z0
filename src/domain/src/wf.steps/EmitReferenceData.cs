//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = ContentLibField;

    [WfHost]
    public sealed class EmitReferenceData : WfHost<EmitReferenceData>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitReferenceDataStep(wf,this);
            step.Run();
        }
    }

    public ref struct EmitReferenceDataStep
    {
        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitReferenceDataStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            EmissionCount = 0;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();

            ResDataEmitter.index(Wf);
            ResDataEmitter.reference(Wf);
            XedEtlWfHost.create().Run(Wf);
        }
    }
}