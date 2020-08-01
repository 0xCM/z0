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
    
    public readonly struct DecodedPart : IWorkflowEvent<DecodedPart>
    {
        public readonly PartInstructions Instructions;

        [MethodImpl(Inline)]
        public DecodedPart(PartInstructions src)
            => Instructions = src;
                
        public PartId Part 
            => Instructions.Part;

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                
        public string Description
            => $"{Instructions.TotalCount}  {Instructions.Part} instructions decoded";
    }        
}