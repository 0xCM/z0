//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class CaptureWorkflowEvents
    {
        public readonly struct ParseReportCreated : IAppEvent<ParseReportCreated>
        {
            public readonly MemberParseReport Report;

            [MethodImpl(Inline)]
            public ParseReportCreated(MemberParseReport report)
            {
                Report = report;
            }
 
            public string Description
                => $"{Report.RecordCount} records created for {Report.ReportName}";
            
            public ParseReportCreated Zero 
                => Empty;

            public static ParseReportCreated Empty 
                => new ParseReportCreated(MemberParseReport.Empty);
        }        
    }
}