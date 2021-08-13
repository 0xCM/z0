//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static Root;
    using static core;

    partial class ApiExtractor
    {
        void EmitProcessContext(IApiPack pack)
        {
            var flow = Wf.Running("Emitting process context");
            var ts = pack.Timestamp;
            if(!ts.IsNonZero)
                ts = now();

            var dir = pack.Archive().ContextRoot();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var procparts = pipe.EmitPartitions(process, ts, dir);
            var regions = pipe.EmitRegions(process, ts, dir);
            pipe.EmitDump(process, pack.ProcDumpPath(process, ts));
            EmitApiCatalog(ts);
            Wf.Ran(flow);
        }
    }
}