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
    using static Flow;
    
    public readonly struct DecodedPart : IWfEvent<DecodedPart>
    {
        public const string EventName = nameof(DecodedPart);

        public WfEventId EventId {get;}
        
        public string ActorName {get;}

        public PartInstructions Instructions {get;}

        public PartId PartId {get;}

        public int TotalCount {get;}
        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public DecodedPart(string actor, PartInstructions src, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            EventId = WfEventId.define(nameof(DecodedPart), ct);
            ActorName = actor;
            Instructions = src;
            PartId = Instructions.Part;
            TotalCount = Instructions.TotalCount;
            Flair = flair;
            Description = AppMsg.Colorize(new {PartId, TotalCount}, Flair);
        }
                
        public string Format()
            => text.format(SSx3, EventId, ActorName, Description);
    }        
}