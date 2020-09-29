//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitPartCilHost : WfHost<EmitPartCilHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitPartCil(wf, this);
            step.Run();
        }
    }
}