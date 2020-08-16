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

    using E = ExtractsParsed;

    public readonly struct ExtractsParsed : IWfEvent<E>
    {   
        public const string EventName = nameof(ExtractsParsed);
        
        public WfEventId EventId {get;}
        
        public string ActorName {get;}
        
        public readonly ApiHostUri Host;
        
        public readonly ParsedExtraction[] Members;

        [MethodImpl(Inline)]
        public ExtractsParsed(string actor, ApiHostUri host, ParsedExtraction[] members, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            ActorName = actor;
            Host = host;
            Members = members;
        }        
        public string Format()
            => text.format(PSx3, EventId, ActorName, Members.Length);
        
        public static ExtractsParsed Empty 
            => default;
    }    
}