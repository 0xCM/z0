//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmWorkflowReports;

    partial class HostCaptureWorkflow
    {
        public static class Events
        {
            public static MembersLocated MembersLocated => MembersLocated.Empty;

            public static ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

            public static ExtractsParsed ExtractsParsed => ExtractsParsed.Empty;
            
            public static ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;

            public static FunctionsDecoded FunctionsDecoded => FunctionsDecoded.Empty;

            public static AsmCodeSaved CodeSaved => AsmCodeSaved.Empty;

            public static ExtractReportSaved HostReportSaved => ExtractReportSaved.Empty;
        }
    }
}