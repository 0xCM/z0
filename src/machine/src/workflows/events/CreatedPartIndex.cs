//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    [Event]
    public readonly struct CreatedPartIndex : IWfEvent<CreatedPartIndex>
    {
        public const string EventName = nameof(CreatedPartIndex);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly GlobalCodeIndex Index;

        public MessageFlair Flair
            => MessageFlair.Cyan;

        [MethodImpl(Inline)]
        public CreatedPartIndex(string worker, GlobalCodeIndex index, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            Index = index;
            ActorName = worker;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(SSx3, EventId, ActorName, GlobalIndexMetrics.from(Index).Format());
    }
}