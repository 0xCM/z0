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

    [Event]
    public readonly struct PartIndexCreated : IWfEvent<PartIndexCreated>
    {
        public const string EventName = nameof(PartIndexCreated);

        public WfEventId EventId {get;}

        public readonly ApiCodeBlockIndex Index;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public PartIndexCreated(WfStepId step, ApiCodeBlockIndex index, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Index = index;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(SSx2, EventId, ApiIndexMetrics.from(Index).Format());
    }
}