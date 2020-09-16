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

    [Step]
    public sealed class EmitExtractReportHost : WfHost<EmitExtractReportHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class EmitCilMembersHost : WfHost<EmitCilMembersHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class DecodeApiMembersHost : WfHost<DecodeApiMembersHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class SpecializeImmediatesHost : WfHost<SpecializeImmediatesHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class CapturePartHost : WfHost<CapturePartHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class ManageCaptureHost : WfHost<ManageCaptureHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class EmitAsmTablesHost : WfHost<EmitAsmTablesHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class EmitX86HexHost : WfHost<EmitX86HexHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class MatchEmissionsHost : WfHost<MatchEmissionsHost>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    [Step]
    public readonly struct EmitCaptureIndexStep : IWfStep<EmitCaptureIndexStep>
    {
        public static WfStepId StepId => Flow.step<EmitCaptureIndexStep>();
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
    public readonly struct WfCaptureControl : IWfStep<WfCaptureControl>
    {
        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state);

        public static WfStepId StepId => step<WfCaptureControl>();
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
    public class CapturePartDataTypesStep : WfHost<CapturePartDataTypesStep>
    {

    }

    [Step]
    public readonly struct CaptureHostsStep : IWfStep<CaptureHostsStep>
    {
        public static WfStepId StepId => step(typeof(CaptureHosts));
    }


    [Step]
    public readonly struct EmitHostArtifactsStep : IWfStep<EmitHostArtifactsStep>
    {
        public const string StepName = nameof(EmitCaptureArtifacts);

        public static WfStepId StepId
            => step<EmitHostArtifactsStep>();
    }

    [Step]
    public readonly struct EmitParsedReportStep : IWfStep<EmitParsedReportStep>
    {
        public static WfStepId StepId
            => step<EmitParsedReportStep>();
    }

    [Step]
    public readonly struct ExtractHostMembersStep : IWfStep<ExtractHostMembersStep>
    {
        public static WfStepId StepId => step<ExtractHostMembersStep>();
    }

    [Step]
    public readonly struct ExtractMembersStep : IWfStep<ExtractMembersStep>
    {
        public const string StepName = nameof(ExtractMembers);

        public static WfStepId StepId => type<ExtractMembersStep>();
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