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

    [Step]
    public sealed class ProcessInstructionsStep : WfHost<ProcessInstructionsStep>
    {
        public static void run(IWfShell wf, ApiPartRoutines fx)
        {
            var step = new ProcessInstructions(wf, new ProcessInstructionsStep(), fx);
            step.Run();
        }
    }
}