//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IndexedEncoded : IWorkflowEvent<IndexedEncoded>
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

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Timestamp, Index.EntryCount);       
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                         
        public string Description
            => Format(); 
    }        
}