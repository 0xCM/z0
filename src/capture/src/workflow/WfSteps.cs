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
    public readonly struct ManageCaptureStep
    {
        public const string StepName = nameof(ManageCapture);

        public static WfStepId StepId => step(typeof(ManageCapture));

        public WfStepId Id => StepId;
    }

    [Step(typeof(CaptureHostMembers), StepName)]
    public readonly struct CaptureHostMembersStep
    {
        public const string StepName = nameof(CaptureHostMembers);

        public static WfStepId StepId => step(typeof(CaptureHostMembers));

        public WfStepId Id => StepId;

    }

    [Step(typeof(CaptureHosts), StepName)]
    public readonly struct CaptureHostsStep
    {
        public const string StepName = nameof(CaptureHosts);

        public static WfStepId StepId => step(typeof(CaptureHosts));

        public WfStepId Id => StepId;
    }

    [Step(typeof(DecodeParsed), StepName)]
    public readonly struct DecodeParsedStep
    {
        public const string StepName = nameof(DecodeParsed);

        public static WfStepId StepId => step(typeof(DecodeParsed));

        public WfStepId Id => StepId;

    }

    [Step(typeof(EmitHostArtifacts), StepName)]
    public readonly struct EmitHostArtifactsStep
    {
        public const string StepName = nameof(EmitHostArtifacts);
    }

    [Step(typeof(EmitExtractReport), StepName)]
    public readonly struct EmitExtractReportStep
    {
        public const string StepName = nameof(EmitExtractReport);
    }

    [Step(typeof(EmitParsedReport), StepName)]
    public readonly struct EmitParsedReportStep
    {
        public const string StepName = nameof(EmitParsedReport);
    }

    [Step(typeof(ExtractHostMembers), StepName)]
    public readonly struct ExtractHostMembersStep
    {
        public const string StepName = nameof(ExtractHostMembers);
    }

    [Step(typeof(ExtractMembers), StepName)]
    public readonly struct ExtractMembersStep
    {
        public const string StepName = nameof(ExtractMembers);
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