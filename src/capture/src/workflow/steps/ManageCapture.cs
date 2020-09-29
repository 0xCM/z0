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
    public sealed class ManageCapture : WfHost<ManageCapture>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [Step]
    public sealed class ManagePartCapture : WfHost<ManagePartCapture>
    {
        public const string StepName = nameof(CapturePartsStep);

        public static WfStepId StepId => step<ManagePartCapture>();
    }
}