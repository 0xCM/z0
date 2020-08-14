//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static RenderPatterns;

    public readonly struct CapturingParts : IWfEvent<CapturingParts>
    {        
        public const string EventName = nameof(CapturingParts);

        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public readonly PartId[] Parts;

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public CapturingParts(string actor, PartId[] parts, CorrelationToken ct, MessageFlair flair = MessageFlair.Cyan)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
            Flair = flair;
            Parts = parts;            
        }
        
        public string Format()
            => text.format(PSx3, EventId, ActorName, Parts.Format());
    }        
}