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

    using static Seed;
    using E = MachineEvents.DecodedMachine;

    public partial class MachineEvents
    {
        public readonly struct DecodedMachine : IMachineEvent<E>
        {
            public static E Empty => new E(MachineIndex.Empty, Control.array<PartInstructions>());

            [MethodImpl(Inline)]
            public static DecodedMachine Create(MachineIndex index, PartInstructions[] inxs)
                => new DecodedMachine(index, inxs);            

            [MethodImpl(Inline)]
            public DecodedMachine(MachineIndex index, PartInstructions[] inxs)
            {
                Index = index;
                PartInstructions = inxs;
            }
            
            public MachineIndex Index {get;}

            PartInstructions[] PartInstructions {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public IEnumerable<LocatedInstruction> Instructions 
                => PartInstructions.SelectMany(x => x.Content).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

            public int TotalCount => PartInstructions.Sum(x => x.TotalCount);
            
            public E Zero => Empty; 
            
            public string Description
                => $"{TotalCount} instructions decoded from {Index.EntryCount} functions provided by {Index.Hosts.Length} hosts across {Index.Parts.Length} parts";
        }        
    }
}