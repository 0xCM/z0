//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;

    public readonly struct DecodedMachine : IProcessedEvent<DecodedMachine>
    {
        public readonly EncodedIndex Index;

        public readonly PartInstructions[] PartInstructions;        
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedIndex index, PartInstructions[] inxs)
        {
            Index = index;
            PartInstructions = inxs;
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
        
        public IEnumerable<LocatedInstruction> Instructions 
            => PartInstructions.SelectMany(x => x.Content).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

        public int TotalCount 
            => PartInstructions.Sum(x => x.TotalCount);                    
        
        public string Description
            => $"{TotalCount} instructions decoded from {Index.EntryCount} functions provided by {Index.Hosts.Length} hosts across {Index.Parts.Length} parts";
    }        
}