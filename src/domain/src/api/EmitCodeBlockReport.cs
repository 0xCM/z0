//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [WfHost]
    public sealed class EmitCodeBlockReport : WfHost<EmitCodeBlockReport>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCodeBlockReportStep(wf, this);
            step.Run();
        }
    }

    ref struct EmitCodeBlockReportStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        Count EmissionCount;

        Index<ApiCodeDescriptor> Descriptors;

        [MethodImpl(Inline)]
        public EmitCodeBlockReportStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            EmissionCount = 0;
            Descriptors = default;
            Wf.Created();
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var dst = Wf.Db().IndexTable("apihex.index");
            Descriptors = ApiCode.descriptors(Wf);
            EmissionCount = ApiCode.emit(Descriptors.Storage, dst);
            Wf.EmittedTable<ApiCodeDescriptor>(EmissionCount, dst);
        }
    }
}
