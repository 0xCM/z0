//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct IndexedEncoded : IWfEvent<IndexedEncoded>
    {
        public const string EventName = nameof(IndexedEncoded);
                
        public WfEventId Id {get;}

        public string ActorName {get;}

        public readonly EncodedIndex Index;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 

        [MethodImpl(Inline)]
        public IndexedEncoded(string worker, EncodedIndex index, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            Index = index;
            ActorName = worker;
        }
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(SSx3, Id, ActorName, Index.EntryCount);               
    }        
}