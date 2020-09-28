//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Flow;

    [WfHost]
    public sealed class EmitCaptureIndexHost : WfHost<EmitCaptureIndexHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new CaptureIndexBuilder(wf,this);
        }
    }
}