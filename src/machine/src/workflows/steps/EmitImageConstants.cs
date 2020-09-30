//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitImageConstants : WfHost<EmitImageConstants>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageConstantsStep(wf, this);
            step.Run();
        }
    }
}