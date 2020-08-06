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

    public readonly struct CapturedHost : IWfEvent<CapturedHost>
    {            
        public const string EventName = nameof(CapturedHost);
        
        public WfEventId Id {get;}

        public string ActorName {get;}
        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host, CorrelationToken? ct = null, [CallerMemberName] string actor = null)
        {
            Host = host;
            Id = WfEventId.define(EventName, ct);
            ActorName = actor;
        }

        public object Description
            => new {Host};
        public string Format() 
            => text.format(PSx3, Id, ActorName, Description);
    }    
}