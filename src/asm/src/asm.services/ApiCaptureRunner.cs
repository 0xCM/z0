//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    [Flags]
    public enum CaptureRunnerOptions : byte
    {
        None = 0,

        EmitImm = 1,

        RebaseMembers = 2,

        EmitDump = 4,
    }

    public class ApiCaptureRunner : WfService<ApiCaptureRunner>
    {
        const CaptureRunnerOptions DefaultOptions = CaptureRunnerOptions.EmitDump | CaptureRunnerOptions.RebaseMembers | CaptureRunnerOptions.EmitImm;

        public Index<AsmMemberRoutine> Run()
        {
            return Run(Wf.Api.PartIdentities, DefaultOptions);
        }

        public Index<AsmMemberRoutine> Run(Index<PartId> parts, CaptureRunnerOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts.Storage));
            var captured = CaptureParts(parts);
            var emitImm = (options & CaptureRunnerOptions.EmitImm) != 0;
            if(emitImm)
                EmitImm(parts);

            var rebase = (options & CaptureRunnerOptions.RebaseMembers) != 0;
            if(rebase)
                RebaseMembers();

            var dump = (options & CaptureRunnerOptions.EmitDump) != 0;
            if(dump)
                EmitDump();

            return captured;
        }

        public Index<AsmMemberRoutine> Run(PartId part, CaptureRunnerOptions? options = null)
        {
            return Run(root.array(part), CaptureRunnerOptions.EmitImm);
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