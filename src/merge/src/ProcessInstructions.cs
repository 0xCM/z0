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
            var step = new PartRoutinesProcessor(wf, this, state);
            step.Run();
        }
    }

    public readonly struct PartRoutinesProcessor
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        public static PartRoutinesProcessor service(IWfShell wf, ApiPartRoutines src)
            => new PartRoutinesProcessor(wf, WfShell.host(typeof(PartRoutinesProcessor)), src);

        public PartRoutinesProcessor(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Source = src;
        }

        public void Dispose()
        {

        }

        public void ProcessEnlisted()
            => AsmProcessors.parts(Wf).Process(Source);

        public void ProcessCalls()
            => EmitCallIndex.create(Source).Run(Wf);

        public void RenderSemantic()
            => AsmSemanticRender.create(Wf).Render(Source);

        public void ProcessJumps()
        {
            using var step = new AsmJmpProcessor(Wf, Source);
            step.Process();
        }

        public void Run()
        {
            // try
            // {
            //     ProcessJumps();
            //     ProcessEnlisted();
            //     RenderSemantic();
            //     ProcessCalls();
            // }
            // catch(Exception e)
            // {
            //     Wf.Error(e);
            // }
        }
    }
}