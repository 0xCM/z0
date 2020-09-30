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

    ref struct ProcessInstructionsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        public ProcessInstructionsStep(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        void ProcessJumps()
        {
            using var processor = new AsmJmpProcessor(Wf, Source);
            processor.Process();
        }

        public void Run()
        {
            Wf.Running(Host, Source.Part);
            try
            {
                ProcessJumps();
                AsmProcessors.parts(Wf).Process(Source);
                SemanticRenderSvc.run(Source);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(Host, Source.Part);
        }
    }
}