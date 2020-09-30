//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitFieldLiterals : WfHost<EmitFieldLiterals>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldLiteralsStep(wf, this);
            step.Run();
        }
    }
}