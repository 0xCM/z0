//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct MachineWorkflowConfig
    {
        public static MachineWorkflowConfig load(FilePath src)
        {
            var config = AppSettings.load<MachineWorkflowConfig>(src);
            return config;
        }
        
        public bool EnableCapture;
    }
    
    public struct CaptureWorkflowConfig
    {
        public bool EmitPrimaryArtifacts;

        public bool EmitImmArtifacts;

        public bool CheckExecution;

        public bool DuplicateCheck;

        public bool HandleExtractsParsed;

        public bool CollectAsmStats;

        public bool MatchEmissions;

        public bool HandleExtractReportSaved;

        public bool HandleExtractReportCreated;

        public bool HandleParseReportCreated;
     }
}