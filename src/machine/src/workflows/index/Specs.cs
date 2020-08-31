//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RenderPatterns;

    using Z0.Asm;

    [Step(typeof(ProcessInstructions))]
    public readonly struct ProcessInstructionsStep : IWfStep<ProcessInstructionsStep>
    {
        public const string StepName = nameof(ProcessInstructions);

        public static WfStepId StepId
            => AB.step<ProcessInstructionsStep>();

        public void Run(IWfShell wf, params WfStepArgs[] args)
        {
            //using var step = new ProcessInstructions()
        }
    }

    [Step(typeof(ProcessPartFiles))]
    public readonly struct ProcessPartFilesStep : IWfStep<ProcessPartFilesStep>
    {
        public const string StepName = nameof(ProcessPartFiles);

        public static WfStepId StepId
            => AB.step<ProcessPartFilesStep>();
    }

    [Step(typeof(EmitCallIndex))]
    public readonly struct EmitCallIndexStep : IWfStep<EmitCallIndexStep>
    {
        public const string StepName = nameof(EmitCallIndex);

        public static WfStepId StepId
            => AB.step<EmitCallIndexStep>();
    }

    [Step(typeof(CaptureResBytes))]
    public readonly struct CaptureResBytesStep : IWfStep<CaptureResBytesStep>
    {
        public const string StepName = nameof(CaptureResBytes);

        public static WfStepId StepId
            => AB.step<CaptureResBytesStep>();
    }

    [Step(typeof(EmitBitMasks))]
    public readonly struct EmitBitMasksStep : IWfStep<EmitBitMasksStep>
    {
        public const string StepName = nameof(EmitBitMasks);

        public const string RunningPattern = "Emitting bitmasks to {0}";

        public const string RanPattern = "Emitted {0} bitmasks to {1}";
    }

    [Step(typeof(EmitPartCil))]
    public readonly struct EmitPartCilStep : IWfStep<EmitPartCilStep>
    {
        public const string DatasetName = "Cil";

        public const string EmissionType = "il";

        public const string StepName = nameof(EmitPartCil);

        public static WfStepId StepId => AB.step<EmitPartCilStep>();

        public const string DataFolder = EmissionType;

        public const string DatasetExt = EmissionType + ExtSep +  DataExt;
    }

    [Step(typeof(Recapture))]
    public readonly struct RecaptureStep : IWfStep<RecaptureStep>
    {
        public const string StepName = nameof(Recapture);
    }

    [Step(typeof(ProcessAsm))]
    public readonly struct ProcessAsmStep : IWfStep<ProcessAsmStep>
    {
        public const string StepName = nameof(ProcessAsm);

        public static WfStepId StepId => AB.step<ProcessAsmStep>();
    }

    [Step(typeof(Engine))]
    public readonly struct Engines : IWfStep<Engines>
    {
        public const string StepName = nameof(Engine);

        public static WfStepId StepId => AB.step<Engines>();
    }

    [Step(typeof(EmitPeHeaders))]
    public readonly struct EmitPeHeadersStep : IWfStep<EmitPeHeadersStep>
    {
        public const string StepName = nameof(EmitPeHeaders);
    }

    [Step(typeof(EmitPeImage))]
    public readonly struct EmitPeImageStep : IWfStep<EmitPeImageStep>
    {
        public const string StepName = nameof(EmitPeImage);

        public const string DataType = "hexline";

        public const string DatasetName = "PeImage";
    }

    [Step(typeof(EmitProjectDocs))]
    public readonly struct EmitProjectDocsStep
    {
        public const string StepName = nameof(EmitProjectDocs);
    }

    [Step(typeof(EmitContentCatalog))]
    public readonly struct EmitContentCatalogStep
    {
        public const string StepName = nameof(EmitContentCatalog);

        public const string DatasetName = "ContentCatalog";
    }

    [Step(typeof(EmitImageConstants))]
    public readonly struct EmitImageConstantsStep
    {
        public const string StepName = nameof(EmitImageConstants);
    }

    [Step(typeof(EmitDatasetsStep))]
    public readonly struct EmitEnumCatalogStep
    {
        public const string StepName = nameof(EmitEnumCatalog);
    }

    [Step(typeof(EmitFieldLiterals))]
    public readonly struct EmitFieldLiteralsStep : IWfStep<EmitFieldLiteralsStep>
    {
        public const string StepName = nameof(EmitFieldLiterals);

        public static WfStepId StepId
            => AB.step<EmitFieldLiteralsStep>();
    }

    [Step(typeof(EmitStringRecords))]
    public readonly struct EmitStringRecordsStep
    {
        public const string StepName = nameof(EmitStringRecords);

        public const string DataType = "strings";

        public const string UserKind = nameof(PartStringKind.User);

        public const string SystemKind = nameof(PartStringKind.System);

        public const string TargetFolder = DataType + Plural;

        public const string DataTypeExt = DataType + ExtSep + DataExt;

        public const string UserKindExt = UserKind + ExtSep + DataTypeExt;

        public const string SystemKindExt = SystemKind + ExtSep + DataTypeExt;
    }

    [Step(typeof(EmitPartStrings))]
    public readonly struct EmitPartStringsStep : IWfStep<EmitPartStringsStep>
    {
        public const string StepName = nameof(EmitPartStrings);

        public const string EmissionType = EmitStringRecordsStep.DataType;

        public static WfStepId StepId
            => AB.step<EmitPartStringsStep>();

        public static string ExtName(PartStringKind kind)
            => (kind == PartStringKind.System ? EmitStringRecordsStep.SystemKindExt : EmitStringRecordsStep.UserKindExt).ToLower();
    }

    [Step(typeof(CreateGlobalIndex))]
    public readonly struct CreateGlobalIndexStep : IWfStep<CreateGlobalIndexStep>
    {
        public const string StepName = nameof(CreateGlobalIndex);

        public static WfStepId StepId
            => AB.step<CreateGlobalIndexStep>();
    }

    [Step(typeof(EmitImageBlobs))]
    public readonly struct EmitImageBlobsStep : IWfStep<EmitImageBlobsStep>
    {
        public const string StepName = nameof(EmitImageBlobs);

        public const string EmissionType = "Metablobs";

        public static WfStepId StepId
            => AB.step<EmitBitMasksStep>();
    }

    [Step(typeof(EmitImageSummaries))]
    public readonly struct EmitImageSummariesStep : IWfStep<EmitImageSummariesStep>
    {
        public const string StepName = nameof(EmitImageSummaries);

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
    public readonly struct ParseAsmFilesStep
    {
        public const string StepName = nameof(ParseAsmFiles);
    }

    [Step(typeof(EmitDatasets))]
    public readonly struct EmitDatasetsStep : IWfStep<EmitDatasetsStep>
    {
        public const string StepName = nameof(EmitDatasets);

        public static WfStepId StepId => AB.step<EmitDatasetsStep>();
    }

    [Step(typeof(EmitFieldMetadata))]
    public readonly struct EmitFieldMetadataStep : IWfStep<EmitFieldMetadataStep>
    {
        public const string StepName = nameof(EmitFieldMetadata);

        public const string DatasetName = "FieldMetadata";

        public static WfStepId StepId
            => AB.step<EmitFieldMetadataStep>();
    }

    [Step(typeof(EmitImageContent))]
    public readonly struct EmitImageContentStep : IWfStep<EmitImageContentStep>
    {
        public const string StepName = nameof(EmitImageContent);
    }

    [Step(typeof(EmitMetadataSets))]
    public readonly struct EmitMetadataSetsStep : IWfStep<EmitMetadataSetsStep>
    {
        public const string WorkerName = nameof(EmitMetadataSets);
    }

    [Step(typeof(EmitStepList))]
    public readonly struct EmitStepListStep : IWfStep<EmitStepListStep>
    {
        public const string StepName = nameof(EmitStepList);

        public static WfStepId StepId
            => AB.step<EmitStepListStep>();
    }
}