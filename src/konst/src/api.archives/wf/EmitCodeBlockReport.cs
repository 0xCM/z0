//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitCodeBlockReport : WfHost<EmitCodeBlockReport>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCodeBlockReportStep(wf, this);
            step.Run();
        }
    }
}