//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public class ApiCaptureRunner : WfService<ApiCaptureRunner>
    {
        IAsmContext Asm;

        protected override void OnInit()
        {
            Asm = Wf.AsmContext();
        }

        public void Run()
        {
            var parts = Wf.Api.PartIdentities;
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(parts));
            var captured = RunPrimary(parts);
            EmitImm(parts);
            RebaseMembers();
            EmitDump();
        }

        Index<AsmMemberRoutine> RunPrimary(Index<PartId> parts)
        {
            var flow = Wf.Running("ApiCapture");
            using var step = Wf.ApiCapture(Asm);
            var captured = step.CaptureApi();
            Wf.Ran(flow);
            return captured;
        }

        void EmitImm(Index<PartId> parts)
        {
            var flow = Wf.Running();
            Wf.ImmEmitter().Emit(parts);
            Wf.Ran(flow);
        }

        void Evaluate(Index<PartId> parts)
        {
            var flow = Wf.Running();
            var evaluate = Wf.EvalControl();
            evaluate.Execute();
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