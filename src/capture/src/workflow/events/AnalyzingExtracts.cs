//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static z;

    [Event]
    public readonly struct AnalyzingExtracts : IWfEvent<AnalyzingExtracts>
    {
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public ApiMemberExtract[] Extracts {get;}

        public uint ExtractCount
            => (uint)Extracts.Length;

        [MethodImpl(Inline)]
        internal AnalyzingExtracts(string worker, ApiMemberExtract[] extracts, CorrelationToken ct)
        {
            EventId = evid(nameof(AnalyzingExtracts), ct);
            ActorName = worker;
            Extracts = extracts;
        }

        public string Format()
            => text.format(PSx3, EventId, ActorName, ExtractCount);
    }
}