//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IndexedInstructions : IProcessedEvent<IndexedInstructions>
    {
        public readonly LocatedInstructions Index;

        [MethodImpl(Inline)]
        public IndexedInstructions(LocatedInstructions index)
            => Index = index;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                         
        public string Description
            => $"Created located instruction index with {Index.Indexed.Length} entries";
    }        
}