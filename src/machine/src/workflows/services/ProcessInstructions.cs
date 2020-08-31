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

        readonly PartAsmFx Source;

        public ProcessInstructions(IWfShell wf, PartAsmFx src)
        {
            Wf = wf;
            Source = src;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        void ProcessJumps()
        {
            using var processor = new ProcessAsmJmp(Wf, Source);
            processor.Process();
        }

        public void Run()
        {
            Wf.Running(StepId, Source.Part);
            try
            {
                ProcessJumps();
                AsmProcessors.parts(Wf).Process(Source);
                RenderSemantic.Render(Source);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(StepId, Source.Part);
        }
    }
}