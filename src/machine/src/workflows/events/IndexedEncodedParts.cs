//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static RenderPatterns;

    [Event]
    public readonly struct IndexedEncodedParts : IWfEvent<IndexedEncodedParts>
    {
        public const string EventName = nameof(IndexedEncodedParts);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly GlobalCodeIndex Index;

        public MessageFlair Flair
            => MessageFlair.Cyan;

        [MethodImpl(Inline)]
        public IndexedEncodedParts(string worker, GlobalCodeIndex index, CorrelationToken ct)
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