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
        const CaptureWorkflowOptions DefaultOptions = CaptureWorkflowOptions.CaptureContext | CaptureWorkflowOptions.EmitImm;

        public Index<AsmMemberRoutine> Run()
        {
            return Run(Wf.Api.PartIdentities, DefaultOptions);
        }

        public Index<AsmMemberRoutine> Run(Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts.Storage));
            var captured = CaptureParts(parts);

            if((options & CaptureWorkflowOptions.EmitImm) != 0)
                EmitImm(parts);

            if((options & CaptureWorkflowOptions.CaptureContext) != 0)
                EmitContext();

            return captured;
        }

        public Index<AsmMemberRoutine> Run(PartId part, CaptureWorkflowOptions? options = null)
            => Run(root.array(part), CaptureWorkflowOptions.EmitImm);

        Index<AsmMemberRoutine> CaptureParts(Index<PartId> parts)
        {
            var flow = Wf.Running();
            using var step = Wf.ApiCapture();
            var captured = step.CaptureApi(parts);
            Wf.Ran(flow);
            return captured;
        }

        void EmitImm(Index<PartId> parts)
        {
            var flow = Wf.Running();
            Wf.ImmEmitter().Emit(parts);
            Wf.Ran(flow);
        }

        BasedApiMemberCatalog EmitRebase(Timestamp ts)
        {
            var rebasing = Wf.Running();
            var catalog = Wf.ApiServices().RebaseMembers(ts);
            Wf.Ran(rebasing);
            return catalog;
        }

        Index<ProcessImageRow> EmitMaps(Timestamp ts)
            => ImageMaps.emit(Wf, ts);

        void EmitDump(Timestamp ts)
        {
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = Db.ProcDumpPath(name).EnsureParentExists();
            dst.Delete();
            var flow = Wf.EmittingFile(dst);
            DumpEmitter.emit(process, dst.Name, DumpTypeOption.Full);
            Wf.EmittedFile(flow,1);
        }

        void EmitContext()
        {
            var ts = root.timestamp();
            EmitRebase(ts);
            EmitMaps(ts);
            EmitDump(ts);
        }
    }
}