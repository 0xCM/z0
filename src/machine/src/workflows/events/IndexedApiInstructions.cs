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
    public readonly struct IndexedApiInstructions : IWfEvent<IndexedApiInstructions>
    {
        public static string EventName => nameof(IndexedApiInstructions);

        public WfEventId EventId {get;}

        public readonly ApiInstructions Index;

        [MethodImpl(Inline)]
        public IndexedApiInstructions(ApiInstructions src, CorrelationToken ct)
        {
            EventId = (EventName, ct);
            Index = src;
        }

        public FlairKind Flair
            => FlairKind.Ran;

        public string Format()
            => text.format(PSx2, EventId, Index.Storage.Length);
    }
}