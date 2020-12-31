//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class XedEtlWfHost : WfHost<XedEtlWfHost>
    {
        public const string StepName = "xed";

        protected override void Execute(IWfShell wf)
        {
            using var step = XedWf.create(wf);
            step.Run();
        }
    }
}