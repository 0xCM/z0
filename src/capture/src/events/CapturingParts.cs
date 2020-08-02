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
    
    public readonly struct CapturingParts : IWfEvent<CapturingParts>
    {
        const string Pattern = "{0}: Capturing {1}";

        public WfEventId Id {get;}

        public readonly PartId[] Parts;

        [MethodImpl(Inline)]
        public CapturingParts(PartId[] parts, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(nameof(CapturingParts), ct);
            Parts = parts;            
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public string Format()
            => text.format(Pattern, Id, Parts.Format());
    }        
}