//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static OldFlow;

    [Event]
    public readonly struct IndexedInstructions : IWfEvent<IndexedInstructions>
    {
        const string Pattern = IdMarker + "Created located instruction index with {1} entries";
        
        public WfEventId EventId {get;}

        public readonly LocatedInstructions Index;

        [MethodImpl(Inline)]
        public IndexedInstructions(LocatedInstructions src)
        {
            EventId = WfEventId.define(nameof(DecodedPart));
            Index = src;
        }
        
        public MessageFlair Flair 
            => MessageFlair.Cyan;
                         
        public string Format()
            => text.format(Pattern, EventId, Index.Indexed.Length);        
    }        
}