//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LoadedParseReport : IWorkflowEvent<LoadedParseReport>
    {
        public readonly MemberParseReport Report;
        
        public readonly FilePath ReportPath;

        [MethodImpl(Inline)]
        public LoadedParseReport(MemberParseReport report, FilePath src)
        {
            Report = report;
            ReportPath = src;
        }
                        
        public string Description
            => text.concat($"Loaded {Report.RecordCount} {Report.ReportName} records from {ReportPath}");
    }        
}