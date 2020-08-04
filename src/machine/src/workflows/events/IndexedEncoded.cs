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
        const string Pattern = SS1x3;
        
        public WfEventId Id {get;}

        public string WorkerName {get;}

        public readonly EncodedIndex Index;

        [MethodImpl(Inline)]
        public IndexedEncoded(string worker, EncodedIndex index, CorrelationToken ct)
        {
            Id = wfid(nameof(IndexedEncoded), ct);
            Index = index;
            WorkerName = worker;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(Pattern, Id, WorkerName, Index.EntryCount);               
    }        
}