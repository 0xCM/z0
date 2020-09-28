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
    public sealed class SpecializeImmediatesHost : WfHost<SpecializeImmediatesHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class ManageCaptureHost : WfHost<ManageCaptureHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }


    [WfHost]
    public sealed class EmitX86HexHost : WfHost<EmitX86HexHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class MatchEmissionsHost : WfHost<MatchEmissionsHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [Step]
    public sealed class EvaluateStep : WfHost<EvaluateStep>
    {
        public static WfStepId StepId
            => step<EvaluateStep>();
    }

    [Step]
    public sealed class EmitImmSpecialsStep : WfHost<EmitImmSpecialsStep>
    {
        public static WfStepId StepId
            => Flow.step<EmitImmSpecialsStep>();
    }

    [Step]
    public readonly struct ManagePartCaptureStep : IWfStep<ManagePartCaptureStep>
    {
        public const string StepName = nameof(CaptureParts);

        public static WfStepId StepId => step<ManagePartCaptureStep>();
    }

    [Step]
    public readonly struct MatchAddressesStep : IWfStep<MatchAddressesStep>
    {
        public static WfStepId StepId
            => step<MatchAddressesStep>();
    }
}