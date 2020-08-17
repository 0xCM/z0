//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static RenderPatterns;

    [Step(typeof(ProcessPartFiles))]
    public readonly struct ProcessPartFilesStep
    {
        public const string StepName = nameof(ProcessPartFiles);
    }

    [Step(typeof(AnalyzeCalls))]
    public readonly struct AnalyzeCallsStep
    {
        public const string StepName = nameof(AnalyzeCalls);
    }

    [Step(typeof(CaptureResBytes))]
    public readonly struct CaptureResBytesStep
    {
        public const string StepName = nameof(CaptureResBytes);
    }

    [Step(typeof(EmitBitMasks))]
    public readonly struct EmitBitMasksStep
    {
        public const WfStepKind Kind = WfStepKind.EmitBitMasks;
        
        public const string Name = nameof(EmitBitMasks);
        
        public const string RunningPattern = "Emitting bitmasks to {0}";

        public const string RanPattern = "Emitted {0} bitmasks to {1}";        
    }

    [Step(typeof(EmitCilDatasets))]
    public readonly struct EmitCilDatasetsStep
    {
        public const string StepName = nameof(EmitCilDatasets);
        
        public const string DatasetName = "Cil";

        public const string DataType = "il";

        public const string DataFolder = DataType;

        public const string DatasetExt = DataType + XDelimit +  DataFileExt;
    }

    [Step(typeof(Recapture))]
    public readonly struct RecaptureStep
    {
        public const string StepName = nameof(RecaptureStep);
    }    
    
    [Step(typeof(ProcessAsm))]
    public readonly struct ProcessAsmStep
    {
        public const string StepName = nameof(ProcessAsm);
    }

    [Step(typeof(Engine))]
    public readonly struct RunProcessorsStep
    {
        public const WfStepKind Kind = WfStepKind.RunProcessors;
        
        public const string StepName = nameof(Engine);           
    }    

    [Step(typeof(EmitPeHeaders))]
    public readonly struct EmitPeHeadersStep
    {
        public const string StepName = nameof(EmitPeHeaders);
    }

    [Step(typeof(EmitPeImage))]
    public readonly struct EmitPeImageStep
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
    
    [Step(typeof(EmitConstantDatasets))]
    public readonly struct EmitConstantDatasetsStep
    {    
        public const string StepName = nameof(EmitConstantDatasets);       
    }
    
    [Step(typeof(EmitDatasetsStep))]
    public readonly struct EmitEnumCatalogStep
    {
        public const string StepName = nameof(EmitEnumCatalog);
    }

    [Step(typeof(EmitFieldLiterals))]
    public readonly struct EmitFieldLiteralsStep
    {
        public const string StepName = nameof(EmitFieldLiterals);
    }

    [Step(typeof(EmitStringRecords))]
    public readonly struct EmitStringRecordsStep
    {
        public const string StepName = nameof(EmitStringRecords);

        public const string DataType = "metastring";

        public const string UserKind = "user";

        public const string SystemKind = "system";

        public const string TargetFolder = DataType + Plural;

        public const string DataTypeExt = DataType + XDelimit + DataFileExt;

        public const string UserKindExt = SystemKind + XDelimit + DataTypeExt;

        public const string SystemKindExt = UserKind + XDelimit + DataTypeExt;
    }

    [Step(typeof(EmitPartStrings))]
    public readonly struct EmitPartStringsStep
    {
        public const string StepName = nameof(EmitPartStrings);

        public const string DataType = EmitStringRecordsStep.DataType;
    }   

    [Step(typeof(ProcessInstructions))]
    public readonly struct ProcessInstructionsStep
    {
        public const string StepName = nameof(ProcessInstructions);
    }     

    public readonly struct Controller
    {
        public const string ActorName = nameof(Control);
    }    

    [Step(typeof(EmitBlobs))]
    public readonly struct EmitBlobsStep
    {
        public const string StepName = nameof(EmitBlobs);        

        public const string EmissionType = "Metablobs";
    }    

    [Step(typeof(EmitImageSummaries))]
    public readonly struct EmitImageSummariesStep
    {        
        public const string StepName = nameof(EmitImageSummaries);       
    }

    [Step(typeof(EmitResBytes))]
    public readonly struct EmitResBytesStep
    {
        public const string StepName = nameof(EmitResBytes);
    }
    
    [Step(typeof(ParseAsmFiles))]
    public readonly struct ParseAsmFilesStep
    {
        public const string StepName = nameof(ParseAsmFiles);
    }

    public readonly struct EmitDatasetsStep
    {
        public const string StepName = nameof(EmitDatasets);
    }     

    [Step(typeof(EmitFieldMetadata))]
    public readonly struct EmitFieldMetadataStep
    {
        public const string StepName = nameof(EmitFieldMetadata);

        public const string DatasetName = "FieldMetadata";
    }       

    [Step(typeof(EmitImageContent))]
    public readonly struct EmitImageContentStep
    {        
        public const string StepName = nameof(EmitImageContent);        
    }       
    
    [Step(typeof(EmitMetadataSets))]
    public readonly struct EmitMetadataSetsStep
    {
        public const string WorkerName = nameof(EmitMetadataSets);
    }        
}