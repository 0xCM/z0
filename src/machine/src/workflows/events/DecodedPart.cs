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
    using static Render;
    using static z;

    [Event]
    public readonly struct DecodedPart : IWfEvent<DecodedPart>
    {
        public const string EventName = nameof(DecodedPart);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public PartAsmFx Instructions {get;}

        public PartId PartId {get;}

        public CellCount TotalCount {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public DecodedPart(string actor, PartAsmFx src, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Instructions = src;
            PartId = Instructions.Part;
            TotalCount = Instructions.TotalCount;
            Flair = flair;
        }

        public string Format()
            => text.format(PSx4, EventId, Actor, PartId, TotalCount);
    }
}