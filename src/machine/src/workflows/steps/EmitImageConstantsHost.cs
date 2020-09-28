//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitImageConstantsHost : WfHost<EmitImageConstantsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageConstants(wf, this);
            step.Run();
        }
    }
}