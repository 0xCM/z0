//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static z;
    using static Flow;

    using Asm;

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
        public override void Run(IWfShell shell)
        {

        }
    }

    [Step]
    public readonly struct CaptureHostsStep : IWfStep<CaptureHostsStep>
    {
        public static WfStepId StepId => step(typeof(CaptureHosts));
    }

    [Step]
    public readonly struct DecodeParsedStep : IWfStep<DecodeParsedStep>
    {
        public static WfStepId StepId => step(typeof(DecodeParsed));

    }

    [Step]
    public readonly struct EmitHostArtifactsStep : IWfStep<EmitHostArtifactsStep>
    {
        public const string StepName = nameof(EmitHostArtifacts);

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

    [Step(typeof(ExtractMembers), StepName)]
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
        public const string StepName = nameof(ManagePartCapture);

        public static WfStepId StepId => step<ManagePartCaptureStep>();
    }

    [Step]
    public readonly struct MatchAddressesStep : IWfStep<MatchAddressesStep>
    {
        public static WfStepId StepId
            => step<MatchAddressesStep>();
    }
}