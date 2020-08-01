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

    public readonly struct DecodedMachine : IWorkflowEvent<DecodedMachine>
    {
        const string Pattern = "[{0}, {1}]: {2} instructions decoded from {3} functions provided by {4} hosts across {5} parts";
        
        public readonly EncodedIndex Index;

        public readonly PartInstructions[] PartInstructions;        

        public readonly Timestamp Timestamp;

        public readonly CorrelationToken Correlation;
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedIndex index, PartInstructions[] inxs, CorrelationToken? ct = null)
        {
            Index = index;
            PartInstructions = inxs;
            Timestamp = z.now();
            Correlation = ct ?? CorrelationToken.create();
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
        
        public IEnumerable<LocatedInstruction> Instructions 
            => PartInstructions.SelectMany(x => x.Content).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

        public int TotalCount 
            => PartInstructions.Sum(x => x.TotalCount);                    
        
        public string Format()
            => text.format(Pattern,Timestamp, Correlation, TotalCount, Index.EntryCount, Index.Hosts.Length, Index.Parts.Length);
        
        public string Description
            => Format();

            //$"{TotalCount} instructions decoded from {Index.EntryCount} functions provided by {Index.Hosts.Length} hosts across {Index.Parts.Length} parts";
    }        
}