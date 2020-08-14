//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;
    using static z;

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
}