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
    public sealed class CapturePartDataTypesHost : WfHost<CapturePartDataTypesHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }
}