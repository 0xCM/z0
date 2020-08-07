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
    using static Flow;

    [Event]
    public readonly struct IndexedEncoded : IWfEvent<IndexedEncoded>
    {
        public const string EventName = nameof(IndexedEncoded);
                
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly EncodedParts Index;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 

        [MethodImpl(Inline)]
        public IndexedEncoded(string worker, EncodedParts index, CorrelationToken ct)
        {
            EventId = wfid(EventName, ct);
            Index = index;
            ActorName = worker;
        }
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(SSx3, EventId, ActorName, EncodedPartStats.from(Index).Format());               
    }        
}