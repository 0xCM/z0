//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;    
    using static z;

            
    public readonly struct ExtractReportSaved : IWfEvent<ExtractReportSaved>
    {        
        public const string EventName = nameof(ExtractReportSaved);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public CorrelationToken Ct {get;}

        public MessageFlair Flair {get;}

        public readonly ExtractReport Report;

        public readonly uint RecordCount;

        [MethodImpl(Inline)]
        public ExtractReportSaved(string actor, ExtractReport report, CorrelationToken ct, MessageFlair flair = MessageFlair.Cyan)
        {
            Report = report;
            ActorName = actor;
            Ct = ct;
            RecordCount = (uint)report.RecordCount;
            Flair = flair;
            EventId = evid(EventName, ct);
        }
 
        public string Format()
            => text.format(PSx3, EventId, ActorName, RecordCount);
    }
}