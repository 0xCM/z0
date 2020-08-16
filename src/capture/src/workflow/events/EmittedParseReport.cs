//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static RenderPatterns;

    public readonly struct EmittedParseReport : IWfEvent<EmittedParseReport>
    {        
        public const string EventName = nameof(EmittedParseReport);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly MemberParseReport Report;

        public readonly FilePath Target;        
        
        [MethodImpl(Inline)]
        public EmittedParseReport(string actor, MemberParseReport report, FilePath dst, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);        
            ActorName = actor;
            Report = report;
            Target = dst;        
        }

        public string Format()
            => text.format(PSx4, EventId, ActorName, Report.ApiHost, Report.RecordCount);
    }        
}