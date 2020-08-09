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

    public readonly struct ExtractReportCreated : IWfEvent<ExtractReportCreated, ExtractReport>
    {            
        public const string EventName = nameof(ExtractReportCreated);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public CorrelationToken Ct {get;}

        public AppMsgColor Flair {get;}

        public readonly ExtractReport Report;
        
        public readonly uint RecordCount;

        public readonly string ReportName;

        public object Description {get;}

        public ExtractReport Body         
            => Report;

        [MethodImpl(Inline)]
        public ExtractReportCreated(string actor, ExtractReport report, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            Report = report;
            ActorName = actor;
            Ct = ct;
            RecordCount = (uint)report.RecordCount;
            ReportName = report.ReportName;
            Flair = flair;
            EventId = evid(EventName, ct);
            Description = new {RecordCount, ReportName};
        }
        
        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);
    }    
}