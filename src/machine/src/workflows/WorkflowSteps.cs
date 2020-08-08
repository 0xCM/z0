//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct WorkflowSteps
    {
        public static EmitPeHeadersStep EmitPeHeaders => default;
        
        public static EmitStringRecordsStep EmitStringRecords => default;
        
        public static ParseAsmFilesStep ParseAsmFiles => default;

        public static RunProcessorsStep RunProcessors => default;        
    }   

    public struct WorkflowStepConfig
    {
        public static WorkflowStepConfig Load(IWfContext context)
            => AppSettings.load<WorkflowStepConfig>(context.AppPaths.ConfigRoot + FileName.Define("WorkflowSteps","json"));

        public bool EmitPeHeaders;

        public bool EmitStringRecords;

        public bool ParseAsmFiles;

        public bool RunProcessors;

        public bool CaptureArtifacts;
    }
}