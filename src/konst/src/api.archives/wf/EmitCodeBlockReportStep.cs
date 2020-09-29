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

    ref struct EmitCodeBlockReportStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        FS.FilePath Target;

        Count EmissionCount;

        TableSpan<ApiCodeBlockInfo> Descriptions;

        [MethodImpl(Inline)]
        public EmitCodeBlockReportStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Target = Wf.CaptureRoot + FS.file("apihexindex","csv");
            EmissionCount = 0;
            Descriptions = default;
            Wf.Created(Host);
        }


        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, Target.ToUri());
            Descriptions = DescribeCodeBlocks();
            EmissionCount = ApiCodeBlocks.emit(Descriptions.Storage,Target);
            Wf.Ran(Host, EmissionCount);
        }

        ApiCodeBlockInfo[] DescribeCodeBlocks()
        {
            var archive = ApiHexArchives.create(Wf);
            var files = archive.List();
            var dst = list<ApiCodeBlockInfo>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => x.Describe()));
            return dst.OrderBy(x => x.Base).ToArray();
        }
    }
}
