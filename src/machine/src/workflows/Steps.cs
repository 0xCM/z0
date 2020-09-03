//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static RenderPatterns;

    using static AB;

    [Step]
    public readonly struct ProcessInstructionsStep : IWfStep<ProcessInstructionsStep>
    {
        public static WfStepId StepId
            => step<ProcessInstructionsStep>();
    }

    [Step]
    public readonly struct ProcessPartFilesStep : IWfStep<ProcessPartFilesStep>
    {
        public static WfStepId StepId
            => step<ProcessPartFilesStep>();
    }

    [Step]
    public readonly struct EmitCallIndexStep : IWfStep<EmitCallIndexStep>
    {
        public static WfStepId StepId
            => step<EmitCallIndexStep>();
    }

    [Step(typeof(CaptureResBytes))]
    public readonly struct CaptureResBytesStep : IWfStep<CaptureResBytesStep>
    {
        public static WfStepId StepId
            => step<CaptureResBytesStep>();
    }

    [Step]
    public readonly struct EmitBitMasksStep : IWfStep<EmitBitMasksStep>
    {
        public const string RunningPattern = "Emitting bitmasks to {0}";

        public const string RanPattern = "Emitted {0} bitmasks to {1}";

        public static WfStepId StepId
            => step<EmitBitMasksStep>();
    }

    [Step]
    public readonly struct EmitPartCilStep : IWfStep<EmitPartCilStep>
    {
        public const string DatasetName = "Cil";

        public const string EmissionType = "il";

        public static WfStepId StepId
            => typeof(EmitPartCilStep);

        public const string DataFolder = EmissionType;

        public const string DatasetExt = EmissionType + ExtSep +  DataExt;
    }

    [Step]
    public readonly struct RecaptureStep : IWfStep<RecaptureStep>
    {
        public static WfStepId StepId
            => step<RecaptureStep>();
    }

    [Step]
    public readonly struct ProcessAsmStep : IWfStep<ProcessAsmStep>
    {
        public static WfStepId StepId
            => step<ProcessAsmStep>();

        public static Type StepType => typeof(ProcessAsmStep);
    }

    [Step]
    public readonly struct Engines : IWfStep<Engines>
    {
        public static WfStepId StepId
            => step<Engines>();
    }

    [Step]
    public readonly struct EmitPeHeadersStep : IWfStep<EmitPeHeadersStep>
    {
        public static WfStepId StepId
            => step<EmitPeHeadersStep>();
    }

    [Step]
    public readonly struct EmitPeImageStep : IWfStep<EmitPeImageStep>
    {
        public const string DataType = "hexline";

        public const string DatasetName = "PeImage";

        public static WfStepId StepId => step<EmitPeImageStep>();
    }

    [Step]
    public readonly struct EmitProjectDocsStep : IWfStep<EmitProjectDocsStep>
    {
        public static WfStepId StepId
            => typeof(EmitProjectDocsStep);
    }

    [Step]
    public readonly struct EmitContentCatalogStep : IWfStep<EmitContentCatalogStep>
    {
        public const string DatasetName = "ContentCatalog";

        public static WfStepId StepId
            => step<EmitContentCatalogStep>();
    }

    [Step]
    public readonly struct EmitImageConstantsStep : IWfStep<EmitImageConstantsStep>
    {
        public static WfStepId StepId
            => step<EmitImageConstantsStep>();
    }

    [Step]
    public readonly struct EmitEnumCatalogStep : IWfStep<EmitEnumCatalogStep>
    {
        public static WfStepId StepId
            => step<EmitEnumCatalogStep>();
    }

    [Step]
    public readonly struct EmitFieldLiteralsStep : IWfStep<EmitFieldLiteralsStep>
    {
        public static WfStepId StepId
            => step<EmitFieldLiteralsStep>();
    }

    [Step]
    public readonly struct EmitStringRecordsStep : IWfStep<EmitStringRecordsStep>
    {
        public const string DataType = "strings";

        public const string UserKind = nameof(PartStringKind.User);

        public const string SystemKind = nameof(PartStringKind.System);

        public const string TargetFolder = DataType + Plural;

        public const string DataTypeExt = DataType + ExtSep + DataExt;

        public const string UserKindExt = UserKind + ExtSep + DataTypeExt;

        public const string SystemKindExt = SystemKind + ExtSep + DataTypeExt;

        public static WfStepId StepId
            => step<EmitStringRecordsStep>();
    }

    [Step]
    public readonly struct EmitPartStringsStep : IWfStep<EmitPartStringsStep>
    {
        public const string EmissionType = EmitStringRecordsStep.DataType;

        public static WfStepId StepId
            => AB.step<EmitPartStringsStep>();

        public static string ExtName(PartStringKind kind)
            => (kind == PartStringKind.System ? EmitStringRecordsStep.SystemKindExt : EmitStringRecordsStep.UserKindExt).ToLower();
    }

    [Step]
    public readonly struct CreateGlobalIndexStep : IWfStep<CreateGlobalIndexStep>
    {
        public const string StepName = nameof(CreateGlobalIndex);

        public static WfStepId StepId
            => AB.step<CreateGlobalIndexStep>();
    }

    [Step]
    public readonly struct EmitImageBlobsStep : IWfStep<EmitImageBlobsStep>
    {
        public const string EmissionType = "Metablobs";

        public static WfStepId StepId
            => AB.step<EmitBitMasksStep>();
    }

    [Step]
    public readonly struct EmitImageSummariesStep : IWfStep<EmitImageSummariesStep>
    {
        public static WfStepId StepId
            => AB.step<EmitImageSummariesStep>();
    }

    [Step(typeof(EmitResBytes))]
    public readonly struct EmitResBytesStep : IWfStep<EmitResBytesStep>
    {
        public const string StepName = nameof(EmitResBytes);

        public static WfStepId StepId
            => AB.step<EmitResBytesStep>();

    }

    [Step(typeof(ParseAsmFiles))]
    public readonly struct ParseAsmFilesStep : IWfStep<ParseAsmFilesStep>
    {
        public static WfStepId StepId
            => AB.step<ParseAsmFilesStep>();
    }

    [Step(typeof(EmitDatasets))]
    public readonly struct EmitDatasetsStep : IWfStep<EmitDatasetsStep>
    {
        public static WfStepId StepId => AB.step<EmitDatasetsStep>();
    }

    [Step(typeof(EmitFieldMetadata))]
    public readonly struct EmitFieldMetadataStep : IWfStep<EmitFieldMetadataStep>
    {
        public const string DatasetName = "FieldMetadata";

        public static WfStepId StepId
            => AB.step<EmitFieldMetadataStep>();
    }

    [Step(typeof(EmitImageContent))]
    public readonly struct EmitImageContentStep : IWfStep<EmitImageContentStep>
    {
        public static WfStepId StepId
            => step<EmitImageContentStep>();
    }

    [Step(typeof(EmitMetadataSets))]
    public readonly struct EmitMetadataSetsStep : IWfStep<EmitMetadataSetsStep>
    {
        public static WfStepId StepId
            => step<EmitMetadataSetsStep>();
    }

    [Step(typeof(EmitStepList))]
    public readonly struct EmitStepListStep : IWfStep<EmitStepListStep>
    {
        public static WfStepId StepId
            => step<EmitStepListStep>();
    }
}