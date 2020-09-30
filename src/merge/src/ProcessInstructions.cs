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
    public sealed class ProcessInstructions : WfHost<ProcessInstructions,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            var step = new ProcessInstructionsStep(wf, this, state);
            step.Run();
        }
    }
}