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

        public ApiPartRoutines Instructions {get;}

        public PartId PartId {get;}

        public Count32 TotalCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public DecodedPart(string actor, ApiPartRoutines src, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Instructions = src;
            PartId = Instructions.Part;
            TotalCount = Instructions.InstructionCount;
            Flair = flair;
        }

        public string Format()
            => text.format(PSx4, EventId, Actor, PartId, TotalCount);
    }
}