// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitFieldMetadataHost : WfHost<EmitFieldMetadataHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldMetadata(wf, this);
            step.Run();
        }
    }
}