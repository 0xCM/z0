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
        public const string EventName = nameof(DecodedMachine);
        
        public WfEventId EventId {get;}

        public readonly EncodedParts Index;

        public readonly PartInstructions[] PartInstructions;        
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedParts index, PartInstructions[] inxs, CorrelationToken ct)
        {
            EventId = wfid(EventName, ct);
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
            => text.format(PSx5, EventId, TotalCount, Index.EntryCount, Index.Hosts.Length, Index.Parts.Length);                    
    }        
}