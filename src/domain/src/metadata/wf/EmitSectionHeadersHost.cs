//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitSectionHeadersHost : WfHost<EmitSectionHeadersHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitSectionHeaders(wf, this);
            step.Run();
        }
    }
}