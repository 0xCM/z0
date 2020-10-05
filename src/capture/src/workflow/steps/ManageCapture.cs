//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    [WfHost]
    public sealed class ManageCapture : WfHost<ManageCapture>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [Step]
    public sealed class CaptureParts : WfHost<CaptureParts>
    {

    }
}