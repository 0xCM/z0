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
        const CaptureWorkflowOptions DefaultOptions = CaptureWorkflowOptions.EmitDump | CaptureWorkflowOptions.RebaseMembers | CaptureWorkflowOptions.EmitImm;

        public Index<AsmMemberRoutine> Run()
        {
            return Run(Wf.Api.PartIdentities, DefaultOptions);
        }

        public Index<AsmMemberRoutine> Run(Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts.Storage));
            var captured = CaptureParts(parts);
            var emitImm = (options & CaptureWorkflowOptions.EmitImm) != 0;
            if(emitImm)
                EmitImm(parts);

            var rebase = (options & CaptureWorkflowOptions.RebaseMembers) != 0;
            if(rebase)
                RebaseMembers();

            var dump = (options & CaptureWorkflowOptions.EmitDump) != 0;
            if(dump)
                EmitDump();

            return captured;
        }

        public Index<AsmMemberRoutine> Run(PartId part, CaptureWorkflowOptions? options = null)
        {
            return Run(root.array(part), CaptureWorkflowOptions.EmitImm);
        }

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

        void RebaseMembers()
        {
            var flow = Wf.Running();
            var catalog = Wf.ApiServices().RebaseMembers();
            Wf.Ran(flow);
        }

        void EmitDump()
        {
            ImageMaps.EmitProcessLocations(Wf);
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = Db.ProcDumpPath(name).EnsureParentExists();
            var flow = Wf.EmittingFile(dst);
            dst.Delete();
            DumpEmitter.emit(Runtime.CurrentProcess, dst.Name, DumpTypeOption.Full);
            Wf.Ran(flow);
        }
    }
}