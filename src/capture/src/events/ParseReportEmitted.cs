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

    public readonly struct ParseReportEmitted : IWfEvent<ParseReportEmitted>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly MemberParseReport Report;

        public readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]
        public ParseReportEmitted(MemberParseReport report, FilePath path)
        {
            Report = report;
            TargetPath = path;
        }

        public string Format()
            => $"{Report.RecordCount} {Report.ApiHost} {Report.ReportName} records saved to {TargetPath}";
        
        public ParseReportEmitted Zero 
            => Empty;

        public static ParseReportEmitted Empty 
            => new ParseReportEmitted(MemberParseReport.Empty, FilePath.Empty);
    }        

}