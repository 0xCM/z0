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
    using static FormatLiterals;

    [Event]
    public readonly struct DecodedMachine : IWfEvent<DecodedMachine>
    {
        public const string EventName = nameof(DecodedMachine);
        
        public WfEventId EventId {get;}

        public readonly EncodedParts Index;

        public readonly PartInstructions[] Data;        
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedParts index, PartInstructions[] src, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Index = index;
            Data = src;
        }
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                
        public IEnumerable<LocatedInstruction> Instructions 
            => Data.SelectMany(x => x.Located);
            //=> PartInstructions.SelectMany(x => x.Data).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

        public int TotalCount 
            => Data.Sum(x => x.TotalCount);                    
        
        public string Format()
            => text.format(PSx5, EventId, TotalCount, Index.EntryCount, Index.Hosts.Length, Index.Parts.Length);                    
    }        
}