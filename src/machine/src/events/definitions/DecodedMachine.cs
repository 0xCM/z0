//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;

    using E = MachineEvents.DecodedMachine;

    public partial class MachineEvents
    {
        public readonly struct DecodedMachine : IMachineEvent<E>
        {
            public static E Empty => new E(EncodedIndex.Empty, Root.array<PartInstructions>());

            [MethodImpl(Inline)]
            public static DecodedMachine Create(EncodedIndex index, PartInstructions[] inxs)
                => new DecodedMachine(index, inxs);            

            [MethodImpl(Inline)]
            public DecodedMachine(EncodedIndex index, PartInstructions[] inxs)
            {
                Index = index;
                PartInstructions = inxs;
            }
            
            public EncodedIndex Index {get;}

            PartInstructions[] PartInstructions {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public IEnumerable<LocatedInstruction> Instructions 
                => PartInstructions.SelectMany(x => x.Content).SelectMany(x => x.Content).SelectMany(x => x.Content).OrderBy(x => x.IP);

            public int TotalCount 
                => PartInstructions.Sum(x => x.TotalCount);
            
            public E Zero => Empty; 
            
            public string Description
                => $"{TotalCount} instructions decoded from {Index.EntryCount} functions provided by {Index.Hosts.Length} hosts across {Index.Parts.Length} parts";
        }        
    }
}