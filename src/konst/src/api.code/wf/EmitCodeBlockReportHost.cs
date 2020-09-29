//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitCodeBlockReportHost : WfHost<EmitCodeBlockReportHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCodeBlockReport(wf, this);
            step.Run();
        }
    }
}