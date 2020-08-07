//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Flow;
    
    public readonly struct CapturingParts : IWfEvent<CapturingParts>
    {        

        public WfEventId EventId {get;}

        public readonly PartId[] Parts;

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public CapturingParts(PartId[] parts, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            EventId = WfEventId.define(nameof(CapturingParts), ct);
            Flair = flair;
            Parts = parts;            
        }
        
        public string Format()
            => text.format(PSx2, EventId, Parts.Format());
    }        
}