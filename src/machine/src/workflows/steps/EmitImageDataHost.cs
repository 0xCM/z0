//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    using static Flow;
    using static z;

    [WfHost]
    public sealed class EmitImageDataHost : WfHost<EmitImageDataHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageData(wf, this);
            step.Run();
        }
    }

}