//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;
    using static Flow;

    using Asm;

    [WfHost]
    public sealed class EmitX86HexHost : WfHost<EmitX86HexHost>
    {
        protected override void Execute(IWfShell shell)
        {

        }
    }

    [WfHost]
    public sealed class MatchEmissionsHost : WfHost<MatchEmissionsHost>
    {

    }

    [Step]
    public readonly struct EmitCaptureIndexStep : IWfStep<EmitCaptureIndexStep>
    {
        public static WfStepId StepId => Flow.step<EmitCaptureIndexStep>();
    }

    [Step]
    public readonly struct EmitExtractReportStep : IWfStep<EmitExtractReportStep>
    {
        public static WfStepId StepId
            => Flow.step<EmitExtractReportStep>();
    }

    [Step]
    public readonly struct CaptureMemoryStep : IWfStep<CaptureMemoryStep>
    {
        public static WfStepId StepId
            => Flow.step<CaptureMemoryStep>();
    }

    [Step]
    public class EmitAsmTablesHost : WfHost<EmitAsmTablesHost>
    {
        public override void Run(IWfShell shell)
        {
            throw new System.NotImplementedException();
        }
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
    public class CapturePartStep : WfHost<CapturePartStep>
    {

    }

    [Step]
    public class ManageCaptureStep : WfHost<ManageCaptureStep>
    {
        public override void Run(IWfShell shell)
        {

        }
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
    public readonly struct DecodeApiAsmStep : IWfStep<DecodeApiAsmStep>
    {
        public static WfStepId StepId => step(typeof(DecodeApiAsm));

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
    public class SpecializeImmediatesStep : WfHost<SpecializeImmediatesStep>
    {
        public override void Run(IWfShell shell)
        {

        }
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