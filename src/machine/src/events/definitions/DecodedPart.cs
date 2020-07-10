//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    
    using E = MachineEvents.DecodedPart;

    partial class MachineEvents
    {
        public readonly struct DecodedPart : IMachineEvent<E>
        {
            public PartInstructions Instructions {get;}

            public static E Empty 
                => new E(PartInstructions.Empty);

            [MethodImpl(Inline)]
            public static DecodedPart Create(PartInstructions inxs)
                => new DecodedPart(inxs);            

            [MethodImpl(Inline)]
            public DecodedPart(PartInstructions inxs)
            {
                Instructions = inxs;
            }
            
            public PartId Part 
                => Instructions.Part;

            public AppMsgColor Flair 
                => AppMsgColor.Cyan;
            
            public E Zero 
                => Empty; 
            
            public string Description
                => $"{Instructions.TotalCount}  {Instructions.Part} instructions decoded";
        }        
    }
}