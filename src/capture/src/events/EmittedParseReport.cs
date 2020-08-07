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

    public readonly struct EmittedParseReport : IWfEvent<EmittedParseReport>
    {        
        public const string EventName = nameof(EmittedParseReport);

        public WfEventId Id {get;}

        public string ActorName {get;}

        public readonly MemberParseReport Report;

        public readonly FilePath Target;        
        
        [MethodImpl(Inline)]
        public EmittedParseReport(string actor, MemberParseReport report, FilePath dst, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);        
            ActorName = actor;
            Report = report;
            Target = dst;        
        }

        public string Format()
            => text.format(PSx4, Id, ActorName, Report.ApiHost, Report.RecordCount);
    }        
}