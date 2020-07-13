//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IndexedEncoded : IProcessedEvent<IndexedEncoded>
    {
        public readonly EncodedIndex Index;

        [MethodImpl(Inline)]
        public IndexedEncoded(EncodedIndex index)
            => Index = index;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                         
        public string Description
            => $"{Index.EntryCount} entries created in the code index";
    }        
}