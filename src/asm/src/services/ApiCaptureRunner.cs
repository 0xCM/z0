//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public class ApiCaptureRunner : WfService<ApiCaptureRunner>
    {
        [Op]
        public void Capture(Index<PartId> parts, FS.FolderPath dst)
        {
            var jit = Wf.ApiJit();
            var hex = Wf.ApiHex();
            var capture = Wf.ApiCapture();
            var pipe = Wf.AsmStatementPipe();
            var partcount = parts.Length;
            var hosts = Wf.Api.PartHosts(parts);
            var hostcount = hosts.Length;
            for(var i=0; i<hostcount; i++)
            {
                var host = hosts[i];
                var members = jit.JitHost(host);
                var routines = capture.CaptureMembers(members, dst);
                var hexpath = Db.ApiHexPath(dst, host.Uri);
                var blocks = hex.ReadBlocks(hexpath);
            }
        }

        const CaptureWorkflowOptions DefaultOptions = CaptureWorkflowOptions.CaptureContext | CaptureWorkflowOptions.EmitImm;

        public Index<AsmMemberRoutine> Capture(Index<PartId> parts)
        {
            return Capture(Wf.Api.PartIdentities, DefaultOptions);
        }

        public Index<AsmMemberRoutine> Capture(Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts.Storage));
            var captured = CaptureParts(parts);

            if((options & CaptureWorkflowOptions.EmitImm) != 0)
                EmitImm(parts);

            if((options & CaptureWorkflowOptions.CaptureContext) != 0)
                EmitContext(AsmMemberRoutine.members(captured));

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
                EmitContext(AsmHostRoutines.members(captured));

            return captured;
        }

        public Index<AsmMemberRoutine> Capture(PartId part, CaptureWorkflowOptions? options = null)
            => Capture(root.array(part), CaptureWorkflowOptions.EmitImm);

        Index<AsmMemberRoutine> CaptureParts(Index<PartId> parts)
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

        void EmitContext(ApiMembers members)
        {
            var context = Wf.ProcessContextPipe().Emit();
            var rebasing = Wf.Running();
            var dst = Db.IndexTable<ApiCatalogEntry>(context.Timestamp.Format());
            var entries = Wf.ApiCatalogs().RebaseMembers(members, dst);
            Wf.Ran(rebasing);
        }
    }
}