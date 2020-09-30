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

    [WfHost]
    public sealed class EmitCallIndex : WfHost<EmitCallIndex,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            using var step = new EmitCallIndexStep(wf, this, state);
            step.Run();
        }
    }
}