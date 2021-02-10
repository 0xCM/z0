//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public readonly struct ApiCaptureRunner : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly IAppContext App;

        readonly PartId[] Parts;

        internal ApiCaptureRunner(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(nameof(ApiCaptureRunner));
            Wf = wf.WithHost(Host);
            App = asm.ContextRoot;
            Asm = asm;
            Parts = Wf.Api.PartIdentities;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.enclose(Wf.Api.PartIdentities));
            RunPrimary();
            RunImm();
            RunEvaluate();
            EmitDump();
        }

        void RunPrimary()
        {
            var flow = Wf.Running("ApiCapture");
            using var step = AsmServices.ApiCapture(Wf, Asm);
            step.CaptureApi();
            Wf.Ran(flow);
        }

        void RunImm()
        {
            var flow = Wf.Running("ImmEmitter");
            var service = ApiImmEmitter.create(Wf);
            service.ClearArchive(Parts);
            service.EmitRefined(Parts);
            Wf.Ran(flow);
        }

        void RunEvaluate()
        {
            var flow = Wf.Running("Evaluator");
            var evaluate = Evaluate.control(Wf, App.Random, Wf.Paths.AppCaptureRoot, Pow2.T14);
            evaluate.Execute();
            Wf.Ran(flow);
        }

        void EmitDump()
        {
            var flow = Wf.Running("Emitting process dump");
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = Wf.Db().ProcDumpPath(name).EnsureParentExists();
            dst.Delete();
            DumpEmitter.emit(Runtime.CurrentProcess, dst.Name, DumpTypeOption.Full);
            Wf.Ran(flow, "Emitted process dump");
        }
    }
}