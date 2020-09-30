// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class EmitFieldMetadata : WfHost<EmitFieldMetadata>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitFieldMetadataStep(wf, this);
            step.Run();
        }
    }
}