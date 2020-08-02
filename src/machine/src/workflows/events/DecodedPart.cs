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
    
    public readonly struct DecodedPart : IWfEvent<DecodedPart>
    {
        const string Pattern = "{0}: {1} {2} instructions decoded";

        public WfEventId Id {get;}

        public readonly PartInstructions Instructions;

        [MethodImpl(Inline)]
        public DecodedPart(PartInstructions src)
        {
            Id = WfEventId.define(nameof(DecodedPart));
            Instructions = src;
        }
                
        public PartId Part 
            => Instructions.Part;

        public int TotalCount
            => Instructions.TotalCount;
        
        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
        public string Format()
            => text.format(Pattern, Id, TotalCount, Part);
    }        
}