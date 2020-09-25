//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitBitMasksHost : WfHost<EmitBitMasksHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitBitMasks(wf, this);
            step.Run();
        }
    }
}