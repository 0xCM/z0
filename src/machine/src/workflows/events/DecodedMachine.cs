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
    using static Flow;

    public readonly struct DecodedMachine : IWfEvent<DecodedMachine>
    {
        const string Pattern = "{0}: {1} instructions decoded from {2} functions provided by {3} hosts across {4} parts";
        
        public WfEventId Id {get;}

        public readonly EncodedIndex Index;

        public readonly PartInstructions[] PartInstructions;        
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedIndex index, PartInstructions[] inxs, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(nameof(DecodedHost), ct);
            Index = index;
            PartInstructions = inxs;
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
        
        public IEnumerable<LocatedInstruction> Instructions 
            => PartInstructions.SelectMany(x => x.Content).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

        public int TotalCount 
            => PartInstructions.Sum(x => x.TotalCount);                    
        
        public string Format()
            => text.format(Pattern, Id, TotalCount, Index.EntryCount, Index.Hosts.Length, Index.Parts.Length);                    
    }        
}