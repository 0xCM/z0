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
        const string Pattern = PSx2;

        public WfEventId Id {get;}

        public readonly PartId[] Parts;

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public CapturingParts(PartId[] parts, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            Id = WfEventId.define(nameof(CapturingParts), ct);
            Flair = flair;
            Parts = parts;            
        }
        
        public string Format()
            => text.format(Pattern, Id, Parts.Format());
    }        
}