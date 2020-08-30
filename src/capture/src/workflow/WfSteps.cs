//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AB;

    [Step(typeof(CapturePart), StepName)]
    public readonly struct CapturePartStep : IWfStep<CapturePartStep>
    {
        public const string StepName = nameof(CapturePart);

        public static WfStepId StepId => step(typeof(CapturePart));

        public WfStepId Id => StepId;
    }

    [Step(typeof(ManageCapture), StepName)]
    public readonly struct ManageCaptureStep : IWfStep<ManageCaptureStep>
    {
        public const string StepName = nameof(ManageCapture);

        public static WfStepId StepId
            => step(typeof(ManageCapture));

        public WfStepId Id => StepId;
    }

    [Step(typeof(CaptureHostMembers), StepName)]
    public readonly struct CaptureHostMembersStep : IWfStep<CaptureHostMembersStep>
    {
        public const string StepName = nameof(CaptureHostMembers);

        public static WfStepId StepId
            => step(typeof(CaptureHostMembers));
    }

    [Step(typeof(CaptureHosts), StepName)]
    public readonly struct CaptureHostsStep : IWfStep<CaptureHostsStep>
    {
        public const string StepName = nameof(CaptureHosts);

        public static WfStepId StepId => step(typeof(CaptureHosts));

    }

    [Step(typeof(DecodeParsed), StepName)]
    public readonly struct DecodeParsedStep : IWfStep<DecodeParsedStep>
    {
        public const string StepName = nameof(DecodeParsed);

        public static WfStepId StepId => step(typeof(DecodeParsed));

    }

    [Step(typeof(EmitHostArtifacts), StepName)]
    public readonly struct EmitHostArtifactsStep : IWfStep<EmitHostArtifactsStep>
    {
        public const string StepName = nameof(EmitHostArtifacts);

        public static WfStepId StepId
            => step<EmitHostArtifactsStep>();
    }

    [Step(typeof(EmitExtractReport), StepName)]
    public readonly struct EmitExtractReportStep
    {
        public const string StepName = nameof(EmitExtractReport);
    }

    [Step(typeof(EmitParsedReport), StepName)]
    public readonly struct EmitParsedReportStep : IWfStep<EmitParsedReportStep>
    {
        public const string StepName = nameof(EmitParsedReport);

        public static WfStepId StepId => step<EmitParsedReportStep>();
    }

    [Step(typeof(ExtractHostMembers), StepName)]
    public readonly struct ExtractHostMembersStep
    {
        public const string StepName = nameof(ExtractHostMembers);
    }

    [Step(typeof(ExtractMembers), StepName)]
    public readonly struct ExtractMembersStep : IWfStep<ExtractMembersStep>
    {
        public const string StepName = nameof(ExtractMembers);

        public static WfStepId StepId => AB.step<ExtractMembersStep>();
    }



    [Step(typeof(EmitImmSpecials), StepName)]
    public readonly struct SpecializeImmediatesStep
    {
        public const string StepName = nameof(EmitImmSpecials);
    }

    [Step(typeof(ManagePartCapture), StepName)]
    public readonly struct ManagePartCaptureStep
    {
        public const string StepName = nameof(ManagePartCapture);
    }

    [Step(typeof(MatchAddresses), StepName)]
    public readonly struct MatchAddressesStep
    {
        public const string StepName = nameof(MatchAddresses);
    }
}