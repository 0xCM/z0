//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
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

        TableSpan<ApiCodeBlockInfo> Descriptions;

        [MethodImpl(Inline)]
        public EmitCodeBlockReportStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            EmissionCount = 0;
            Descriptions = default;
            Wf.Created();
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var dst = Wf.Db().Table("apihex.index");
            Descriptions = DescribeCodeBlocks();
            EmissionCount = ApiCodeBlocks.emit(Descriptions.Storage, dst);
            Wf.EmittedTable<ApiCodeBlockInfo>(EmissionCount, dst);
        }

        ApiCodeBlockInfo[] DescribeCodeBlocks()
        {
            var archive = ApiFiles.hex(Wf);
            var files = archive.List();
            var dst = list<ApiCodeBlockInfo>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => x.Describe()));
            return dst.OrderBy(x => x.Base).ToArray();
        }
    }
}
