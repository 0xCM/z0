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

        public WfEventId Id {get;}

        public string ActorName {get;}

        public CorrelationToken Ct {get;}

        public AppMsgColor Flair {get;}

        public readonly ExtractReport Report;
        
        public readonly uint RecordCount;

        public readonly string ReportName;

        public AppMsg Description {get;}

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
            Id = wfid(EventName, ct);
            Description = AppMsg.Colorize(new {RecordCount, ReportName}, flair);
        }
        
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);
    }    
}