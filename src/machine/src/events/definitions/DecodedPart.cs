//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;
    using E = MachineEvents.DecodedPart;

    public partial class MachineEvents
    {
        public readonly struct DecodedPart : IMachineEvent<E>
        {
            public static E Empty => new E(PartInstructions.Empty);

            [MethodImpl(Inline)]
            public static DecodedPart Create(PartInstructions inxs)
                => new DecodedPart(inxs);            

            [MethodImpl(Inline)]
            public DecodedPart(PartInstructions inxs)
            {
                Instructions = inxs;
            }
            
            public PartInstructions Instructions {get;}

            public PartId Part => Instructions.Part;

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public E Zero => Empty; 
            
            public string Description
                => $"{Instructions.Count}  {Instructions.Part} instructions decoded";
        }        
    }
}