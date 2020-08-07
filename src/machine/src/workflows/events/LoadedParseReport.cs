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
        public const string EventName = nameof(LoadedParseReport);
        
        public WfEventId EventId {get;}

        public readonly MemberParseReport Report;
        
        public readonly FilePath ReportPath;

        [MethodImpl(Inline)]
        public LoadedParseReport(MemberParseReport report, FilePath src, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName,ct);
            Report = report;
            ReportPath = src;
        }
                                
        public string Format()
            => text.format(PSx4, EventId, Report.RecordCount, Report.ReportName, ReportPath);
    }        
}