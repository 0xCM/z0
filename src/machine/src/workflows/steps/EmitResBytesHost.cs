//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitResBytesHost : WfHost<EmitResBytesHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitResBytes(wf, this);
            step.Run();
        }
    }
}