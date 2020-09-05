//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;

    using Asm;

    [Step]
    public readonly struct EmitAsmTablesStep : IWfStep<EmitAsmTablesStep>
    {
        public static void control(IWfShell wf, IWfCaptureState state, GlobalCodeIndex encoded)
        {
            using var step = new EmitAsmTables(state,encoded);
            step.Run();
        }

        public static WfStepId StepId
            => step<EmitAsmTablesStep>();
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
        public const string StepName = nameof(ClearCaptureArchives);

        public static WfStepId StepId
            => step<ClearCaptureArchivesStep>();
    }

    [Step]
    public readonly struct WfCaptureControl : IWfStep<WfCaptureControl>
    {
        public const string ActorName = nameof(CaptureControl);

        public static CaptureControl create(WfCaptureState state)
            => new CaptureControl(state);

        public static WfStepId StepId => step<WfCaptureControl>();
    }

    [Step]
    public readonly struct CapturePartStep : IWfStep<CapturePartStep>
    {
        public const string StepName = nameof(CapturePart);

        public static WfStepId StepId
            => step<CapturePartStep>();

        public WfStepId Id => StepId;
    }

    [Step]
    public readonly struct ManageCaptureStep : IWfStep<ManageCaptureStep>
    {
        public const string StepName = nameof(ManageCapture);

        public static WfStepId StepId
            => step<ManageCaptureStep>();

        public WfStepId Id => StepId;
    }

    [Step(typeof(EmitImmSpecials))]
    public readonly struct EmitImmSpecialsStep : IWfStep<EmitImmSpecialsStep>
    {
        public static WfStepId StepId
            => Flow.step<EmitImmSpecialsStep>();
    }

    [Step]
    public readonly struct CaptureHostMembersStep : IWfStep<CaptureHostMembersStep>
    {
        public const string StepName = nameof(CaptureHostMembers);

        public static WfStepId StepId
            => step<CaptureHostMembersStep>();
    }

    [Step]
    public readonly struct CapturePartDataTypesStep : IWfStep<CapturePartDataTypesStep>
    {
        public static WfStepId StepId
            => step<CapturePartDataTypesStep>();
    }

    [Step]
    public readonly struct CaptureHostsStep : IWfStep<CaptureHostsStep>
    {
        public const string StepName = nameof(CaptureHosts);

        public static WfStepId StepId => step(typeof(CaptureHosts));

    }

    [Step]
    public readonly struct DecodeParsedStep : IWfStep<DecodeParsedStep>
    {
        public const string StepName = nameof(DecodeParsed);

        public static WfStepId StepId => step(typeof(DecodeParsed));

    }

    [Step]
    public readonly struct EmitHostArtifactsStep : IWfStep<EmitHostArtifactsStep>
    {
        public const string StepName = nameof(EmitHostArtifacts);

        public static WfStepId StepId
            => step<EmitHostArtifactsStep>();
    }

    // [Step(typeof(EmitExtractReport), StepName)]
    // public readonly struct EmitExtractReportStep : IWfStep<EmitExtractReportStep>
    // {
    //     public const string StepName = nameof(EmitExtractReport);
    // }

    [Step]
    public readonly struct EmitParsedReportStep : IWfStep<EmitParsedReportStep>
    {
        public const string StepName = nameof(EmitParsedReport);

        public static WfStepId StepId
            => step<EmitParsedReportStep>();
    }

    [Step]
    public readonly struct ExtractHostMembersStep : IWfStep<ExtractHostMembersStep>
    {
        public const string StepName = nameof(ExtractHostMembers);

        public static WfStepId StepId => step<ExtractHostMembersStep>();
    }

    [Step(typeof(ExtractMembers), StepName)]
    public readonly struct ExtractMembersStep : IWfStep<ExtractMembersStep>
    {
        public const string StepName = nameof(ExtractMembers);

        public static WfStepId StepId => Flow.step<ExtractMembersStep>();
    }

    [Step]
    public readonly struct SpecializeImmediatesStep
    {
        public const string StepName = nameof(EmitImmSpecials);
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
        public const string StepName = nameof(MatchAddresses);

        public static WfStepId StepId
            => step<MatchAddressesStep>();
    }
}