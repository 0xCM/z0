//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;

    [Event]
    public readonly struct AnalyzingExtractReport : IWfEvent<AnalyzingExtractReport>
    {
        public const string EventName = nameof(AnalyzingExtractReport);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public FilePath ReportPath {get;}

        [MethodImpl(Inline)]
        public AnalyzingExtractReport(string actor, FilePath src, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
            ReportPath = src;
        }

        public object Description
            => new {ReportPath};

        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);
    }
}