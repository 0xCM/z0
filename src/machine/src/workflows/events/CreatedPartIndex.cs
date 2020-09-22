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

        public readonly ApiCaptureIndex Index;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CreatedPartIndex(WfStepId step, ApiCaptureIndex index, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Index = index;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(SSx2, EventId, ApiCaptureMetrics.from(Index).Format());
    }
}