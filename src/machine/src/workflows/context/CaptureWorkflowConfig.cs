//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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