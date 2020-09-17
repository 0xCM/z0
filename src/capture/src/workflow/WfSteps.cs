//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Flow;

    using Asm;

    [WfHost]
    public sealed class CaptureControlHost : WfHost<CaptureControlHost>
    {
        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state, new CaptureControlHost());
    }

    [WfHost]
    public sealed class EmitParsedReportHost : WfHost<EmitParsedReportHost>
    {
    }

    [WfHost]
    public sealed class CapturePartDataTypesHost : WfHost<CapturePartDataTypesHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class CaptureApiHostsHost : WfHost<CaptureApiHostsHost>
    {
        public static WfStepId StepId => step(typeof(CaptureApiHosts));

        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class ExtractMembersHost : WfHost<ExtractMembersHost>
    {
        public const string StepName = nameof(ExtractMembers);

        public static WfStepId StepId => type<ExtractMembersHost>();

        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class ExtractHostMembersHost : WfHost<ExtractHostMembersHost>
    {
        public static WfStepId StepId => step<ExtractHostMembersHost>();

        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class EmitExtractReportHost : WfHost<EmitExtractReportHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class EmitCilMembersHost : WfHost<EmitCilMembersHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class DecodeApiMembersHost : WfHost<DecodeApiMembersHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class SpecializeImmediatesHost : WfHost<SpecializeImmediatesHost>
    {
        protected override void Execute(IWfShell wf)
            => throw missing();
    }

    [WfHost]
    public sealed class CapturePartHost : WfHost<CapturePartHost>
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
    public sealed class EmitAsmTablesHost : WfHost<EmitAsmTablesHost>
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

    [WfHost]
    public sealed class EmitCaptureIndexHost : WfHost<EmitCaptureIndexHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCaptureIndex(wf,this);
        }

    }

    [Step]
    public readonly struct CaptureMemoryStep : IWfStep<CaptureMemoryStep>
    {
        public static WfStepId StepId
            => Flow.step<CaptureMemoryStep>();
    }

    [Step]
    public readonly struct EvaluateStep : IWfStep<EvaluateStep>
    {
        public static WfStepId StepId
            => step<EvaluateStep>();
    }

    [Step]
    public readonly struct ClearCaptureArchivesStep : IWfStep<ClearCaptureArchivesStep>
    {
        public static WfStepId StepId
            => step<ClearCaptureArchivesStep>();
    }


    [Step]
    public readonly struct EmitImmSpecialsStep : IWfStep<EmitImmSpecialsStep>
    {
        public static WfStepId StepId
            => Flow.step<EmitImmSpecialsStep>();
    }

    [Step]
    public readonly struct CaptureHostMembersStep : IWfStep<CaptureHostMembersStep>
    {
        public static WfStepId StepId
            => step<CaptureHostMembersStep>();
    }



    [Step]
    public readonly struct EmitHostArtifactsStep : IWfStep<EmitHostArtifactsStep>
    {
        public const string StepName = nameof(EmitCaptureArtifacts);

        public static WfStepId StepId
            => step<EmitHostArtifactsStep>();
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