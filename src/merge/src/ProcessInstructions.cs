//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static InstructionProcessors;
    using static Konst;
    using static z;

    [Step]
    public sealed class ProcessInstructions : WfHost<ProcessInstructions,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            var step = new ProcessInstructionsStep(wf, this, state);
            step.Run();
        }
    }

    public readonly struct InstructionProcessors
    {
        public static void ProcessJumps(IWfShell wf, in ApiPartRoutines src)
        {
            using var step = new AsmJmpProcessor(wf, src);
            step.Process();
        }

        public static void RenderSemantic(IWfShell wf, in ApiPartRoutines src)
        {
            var svc = AsmSemanticRender.create(wf);
            svc.Render(src);
        }

        public static void ProcessEnlisted(IWfShell wf, in ApiPartRoutines src)
        {
            AsmProcessors.parts(wf).Process(src);
        }

        public static void ProcessCalls(IWfShell wf, in ApiPartRoutines src)
        {
            EmitCallIndex.create().Run(wf,src);
        }

    }

    ref struct ProcessInstructionsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        public ProcessInstructionsStep(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Source = src;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();
            try
            {
                ProcessJumps(Wf, Source);
                ProcessEnlisted(Wf, Source);
                RenderSemantic(Wf, Source);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran();
        }
    }
}