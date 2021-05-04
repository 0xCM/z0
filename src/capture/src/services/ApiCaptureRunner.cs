//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using Z0.Asm;

    public class ApiCaptureRunner : AppService<ApiCaptureRunner>
    {
        [Op]
        public Index<AsmHostRoutines> Capture(Index<PartId> parts, FS.FolderPath dst)
        {
            var jit = Wf.ApiJit();
            var hex = Wf.ApiHex();
            var capture = Wf.ApiCapture();
            var pipe = Wf.AsmStatementPipe();
            var partcount = parts.Length;
            var hosts = Wf.ApiCatalog.PartHosts(parts).View;
            var hostcount = hosts.Length;
            var routines = root.list<AsmHostRoutines>();
            for(var i=0; i<hostcount; i++)
                routines.Add(capture.CaptureHost(memory.skip(hosts,i), dst));
            return routines.ToArray();
        }

        public Index<AsmHostRoutines> Capture(Index<PartId> parts)
            => Capture(Wf.ApiCatalog.PartIdentities, DefaultOptions);

        static ApiMembers members(Index<AsmHostRoutines> src)
            => ApiMembers.create(src.SelectMany(x => x.Members));

        public Index<AsmHostRoutines> Capture(Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts.Storage));
            var captured = CaptureParts(parts);

            if((options & CaptureWorkflowOptions.EmitImm) != 0)
                EmitImm(parts);

            if((options & CaptureWorkflowOptions.CaptureContext) != 0)
            {
                var ts = EmitContext();
                EmitRebase(members(captured), ts);
            }

            return captured;
        }

        public Index<AsmHostRoutines> Capture(ReadOnlySpan<ApiHostUri> hosts, CaptureWorkflowOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(hosts).Format());
            var captured = CaptureHosts(hosts);

            if((options & CaptureWorkflowOptions.EmitImm) != 0)
                EmitImm(hosts);

            if((options & CaptureWorkflowOptions.CaptureContext) != 0)
            {
                var ts = EmitContext();
                EmitRebase(AsmHostRoutines.members(captured), ts);
            }

            return captured;
        }

        public Index<AsmHostRoutines> Capture(PartId part, CaptureWorkflowOptions? options = null)
            => Capture(root.array(part), CaptureWorkflowOptions.EmitImm);

        Index<AsmHostRoutines> CaptureParts(Index<PartId> parts)
        {
            var flow = Wf.Running();
            using var step = Wf.ApiCapture();
            var captured = step.CaptureParts(parts);
            Wf.Ran(flow);
            return captured;
        }

        Index<AsmHostRoutines> CaptureHosts(ReadOnlySpan<ApiHostUri> src)
        {
            var flow = Wf.Running();
            using var step = Wf.ApiCapture();
            var captured = step.CaptureHosts(src);
            Wf.Ran(flow);
            return captured;
        }

        void EmitImm(Index<PartId> parts)
        {
            var flow = Wf.Running();
            Wf.ImmEmitter().Emit(parts);
            Wf.Ran(flow);
        }

        void EmitImm(ReadOnlySpan<ApiHostUri> hosts)
        {
            var flow = Wf.Running();
            Wf.ImmEmitter().Emit(hosts);
            Wf.Ran(flow);
        }

        void EmitRebase(ApiMembers members, Timestamp ts)
        {
            var rebasing = Wf.Running();
            var dst = Db.CaptureContextRoot() + FS.file(string.Format("{0}.{1}", Tables.tableid<ApiCatalogEntry>(), ts.Format()), FS.Csv);
            var entries = Wf.ApiData().RebaseMembers(members, dst);
            Wf.Ran(rebasing);
        }

        Timestamp EmitContext()
        {
            var ts = root.timestamp();
            var dir = Db.CaptureContextRoot();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var summaries = pipe.EmitPartitions(process, pipe.PartitionPath(dir, process, ts));
            var details = pipe.EmitRegions(process, pipe.MemoryRegionPath(dir, process, ts));
            pipe.EmitDump(process, Db.DumpPath(process, ts));
            return ts;
        }

        // void EmitContext(ApiMembers members)
        // {
        //     var ts = EmitContext();
        //     // var dir = Db.CaptureContextRoot();
        //     // var ts = root.timestamp();
        //     // var process = Process.GetCurrentProcess();
        //     // var pipe = Wf.ProcessContextPipe();
        //     // var summaries = pipe.EmitPartitions(process, pipe.PartitionPath(dir, process, ts));
        //     // var details = pipe.EmitRegions(process, pipe.MemoryRegionPath(dir, process, ts));
        //     // pipe.EmitDump(process, Db.DumpPath(process, ts));
        //     EmitRebase(members, ts);
        // }

        const CaptureWorkflowOptions DefaultOptions = CaptureWorkflowOptions.CaptureContext | CaptureWorkflowOptions.EmitImm;
    }
}