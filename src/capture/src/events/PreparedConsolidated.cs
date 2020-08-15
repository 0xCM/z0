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

    public readonly struct PreparedConsolidated : IWfEvent<PreparedConsolidated>
    {            
        public const string EventName = nameof(PreparedConsolidated);
        
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public readonly IApiHost[] Hosts;

        public readonly ApiMember[] Members;

        [MethodImpl(Inline)]
        public PreparedConsolidated(string actor, IApiHost[] hosts, ApiMember[] members, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            ActorName = actor;
            Hosts = hosts;
            Members = members;
        }

        public object Description
            => new {MemberCount = Members.Length, HostCount = Hosts.Length};
        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);
    }    
}