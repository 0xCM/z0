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
        const string Pattern = IdMarker + "{1} entries created in the code index"; 
        
        public WfEventId Id {get;}

        public readonly EncodedIndex Index;

        [MethodImpl(Inline)]
        public IndexedEncoded(EncodedIndex index)
        {
            Id = WfEventId.define(nameof(IndexedEncoded));
            Index = index;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;                                 
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(Pattern, Id, Index.EntryCount);               
    }        
}