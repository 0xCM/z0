//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static Konst;
    using static z;

    using static ProcessInstructionsStep;

    public ref struct ProcessInstructions
    {
        readonly IWfShell Wf;

        readonly ApiPartRoutines Source;

        public ProcessInstructions(IWfShell wf, ApiPartRoutines src)
        {
            Wf = wf;
            Source = src;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        void ProcessJumps()
        {
            using var processor = new AsmJmpProcessor(Wf, Source);
            processor.Process();
        }

        public void Run()
        {
            Wf.Running(StepId, Source.Part);
            try
            {
                ProcessJumps();
                AsmProcessors.parts(Wf).Process(Source);
                SemanticRender.render(Source);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(StepId, Source.Part);
        }
    }
}