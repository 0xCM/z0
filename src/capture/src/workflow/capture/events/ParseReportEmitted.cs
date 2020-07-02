//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParseReportEmitted : IAppEvent<ParseReportEmitted>
    {
        public readonly MemberParseReport Report;

        public readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]
        public ParseReportEmitted(MemberParseReport report, FilePath path)
        {
            Report = report;
            TargetPath = path;
        }

        public string Description
            => $"{Report.RecordCount} {Report.ApiHost} {Report.ReportName} records saved to {TargetPath}";
        
        public ParseReportEmitted Zero 
            => Empty;

        public static ParseReportEmitted Empty 
            => new ParseReportEmitted(MemberParseReport.Empty, FilePath.Empty);
    }        

}