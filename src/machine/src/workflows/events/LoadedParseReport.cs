//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct LoadedParseReport : IWfEvent<LoadedParseReport>
    {
        const string Pattern = IdMarker + "Loaded {1} {2} records from {3}";
        
        public WfEventId EventId {get;}

        public readonly MemberParseReport Report;
        
        public readonly FilePath ReportPath;

        [MethodImpl(Inline)]
        public LoadedParseReport(MemberParseReport report, FilePath src)
        {
            EventId = WfEventId.define(nameof(DecodedPart));
            Report = report;
            ReportPath = src;
        }
                                
        public string Format()
            => text.format(Pattern, EventId, Report.RecordCount, Report.ReportName, ReportPath);
    }        
}