//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static ApiDataModel;

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

        TableSpan<CodeBlockDescriptor> Descriptors;

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
            var dst = Wf.Db().Table("apihex.index");
            Descriptors = ApiData.BlockDescriptors(Wf);
            EmissionCount = ApiData.emit(Descriptors.Storage, dst);
            Wf.EmittedTable<CodeBlockDescriptor>(EmissionCount, dst);
        }
    }
}
