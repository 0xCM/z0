//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitResBytes : WfHost<EmitResBytes>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitResBytesStep(wf, this);
            step.Run();
        }
    }
}