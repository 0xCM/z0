//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatLiterals;

    public readonly struct CapturedHost : IWfEvent<CapturedHost>
    {            
        public const string EventName = nameof(CapturedHost);
        
        public WfEventId EventId {get;}

        public string ActorName {get;}
        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host, CorrelationToken ct, [CallerMemberName] string actor = null)
        {
            Host = host;
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
        }

        public object Description
            => new {Host};
        public string Format() 
            => text.format(PSx3, EventId, ActorName, Description);
    }    
}