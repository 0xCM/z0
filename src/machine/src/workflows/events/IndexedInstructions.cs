//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IndexedInstructions : IWfEvent<IndexedInstructions>
    {
        const string Pattern = "{0}: Created located instruction index with {1} entries";
        
        public WfEventId Id {get;}

        public readonly LocatedInstructions Index;

        [MethodImpl(Inline)]
        public IndexedInstructions(LocatedInstructions src)
        {
            Id = WfEventId.define(nameof(DecodedPart));
            Index = src;
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                         
        public string Format()
            => text.format(Pattern, Id, Index.Indexed.Length);        
    }        
}