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

    public readonly struct ParseReportEmitted : IWfEvent<ParseReportEmitted>
    {
        const string Pattern = PSx6;
        
        public WfEventId Id {get;}

        public string ActorName {get;}

        public readonly MemberParseReport Source;

        public readonly FilePath Target;        
        
        [MethodImpl(Inline)]
        public ParseReportEmitted(string worker, MemberParseReport src, FilePath dst, CorrelationToken ct)
        {
            Id = wfid(nameof(ParseReportEmitted), ct);        
            ActorName = worker;
            Source = src;
            Target = dst;        
        }

        public string Format()
            => text.format(PSx6, Id, ActorName, Source.RecordCount, Source.ApiHost, Source.ReportName, Target);
    }        
}