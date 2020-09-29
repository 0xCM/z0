//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    [WfHost]
    public class ProcessPartFiles : WfHost<ProcessPartFiles,AsmContextProvider>
    {
        protected override void Execute(IWfShell wf, in AsmContextProvider state)
        {
            using var step = new ProcessPartFilesStep(wf, state.Context, wf.Ct);
            step.Run();
        }
    }
}