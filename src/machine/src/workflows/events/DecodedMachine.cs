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
    using static z;
    using static RenderPatterns;

    [Event]
    public readonly struct DecodedMachine : IWfEvent<DecodedMachine>
    {
        public const string EventName = nameof(DecodedMachine);
        
        public WfEventId EventId {get;}

        public readonly EncodedParts Index;

        public readonly PartAsmFx[] Data;        
        
        [MethodImpl(Inline)]        
        public DecodedMachine(EncodedParts index, PartAsmFx[] src, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Index = index;
            Data = src;
        }
        
        public MessageFlair Flair 
            => MessageFlair.Cyan;
                
        public IEnumerable<BasedAsmFx> Instructions 
            => Data.SelectMany(x => x.Located);
 
        public int TotalCount 
            => Data.Sum(x => x.TotalCount);                    
        
        public string Format()
            => text.format(PSx5, EventId, TotalCount, Index.EntryCount, Index.Hosts.Length, Index.Parts.Length);                    
    }        
}