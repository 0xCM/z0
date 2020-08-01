//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IndexedEncoded : IAppEvent<IndexedEncoded>
    {
        const string Pattern = "{0}: {1} entries created in the code index"; 
        public readonly EncodedIndex Index;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public IndexedEncoded(EncodedIndex index)
        {
            Index = index;
            Timestamp = z.now();
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                         
        public string Description
            => text.format(Pattern, Timestamp, Index.EntryCount);
    }        
}