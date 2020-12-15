//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    public sealed class ProcessInstructions : WfHost<ProcessInstructions,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            var step = new ProcessInstructionsStep(wf, this, state);
            step.Run();
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

        void ProcessJumps(in ApiPartRoutines src)
        {
            using var step = new AsmJmpProcessor(Wf, src);
            step.Process();
        }

        void RenderSemantic(in ApiPartRoutines src)
            => AsmSemanticRender.create(Wf).Render(src);

        void ProcessEnlisted(in ApiPartRoutines src)
            => AsmProcessors.parts(Wf).Process(src);

        void ProcessCalls(in ApiPartRoutines src)
            => EmitCallIndex.create(src).Run(Wf);

        public void Run()
        {
            Wf.Running();
            try
            {
                ProcessJumps(Source);
                ProcessEnlisted(Source);
                RenderSemantic(Source);
                ProcessCalls(Source);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }
    }
}