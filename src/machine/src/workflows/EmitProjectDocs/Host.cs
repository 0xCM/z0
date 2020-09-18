
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    [WfHost]
    public sealed class EmitProjectDocsHost : WfHost<EmitProjectDocsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitProjectDocs(wf, this);
            step.Run();
        }
    }
}