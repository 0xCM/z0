//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static Render;

    [Event]
    public readonly struct CapturingParts : IWfEvent<CapturingParts>
    {
        public const string EventName = nameof(CapturingParts);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly PartId[] Parts;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CapturingParts(string actor, PartId[] parts, CorrelationToken ct, FlairKind flair = Running)
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