//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct ExtractReportCreated : IWfEvent<ExtractReportCreated>
    {            
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ExtractReport Report;

        [MethodImpl(Inline)]
        public ExtractReportCreated(ExtractReport report)
        {
            Report = report;
        }

        public string Format()
            => $"{Report.RecordCount} records created for {Report.ReportName}";

        public ExtractReportCreated Zero 
            => Empty;           

        public static ExtractReportCreated Empty 
            => new ExtractReportCreated(ExtractReport.Empty);
    }    
}