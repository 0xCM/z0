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
    public sealed class CaptureApiHostsHost : WfHost<CaptureApiHostsHost>
    {
        public static WfStepId StepId => step(typeof(CaptureApiHosts));

        protected override void Execute(IWfShell wf)
            => throw missing();
    }

}