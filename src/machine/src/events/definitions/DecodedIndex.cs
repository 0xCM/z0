//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using E = MachineEvents.DecodedIndex;

    public partial class MachineEvents
    {
        public readonly struct DecodedIndex : IMachineEvent<E>
        {
            public static E Empty => new E(UriCodeIndex.Empty, Control.array<HostCodeInstructions>());

            [MethodImpl(Inline)]
            public static DecodedIndex Create(UriCodeIndex index, HostCodeInstructions[] inxs)
                => new DecodedIndex(index, inxs);            

            [MethodImpl(Inline)]
            public DecodedIndex(UriCodeIndex index, HostCodeInstructions[] inxs)
            {
                Index = index;
                Instructions = inxs;
            }
            
            public UriCodeIndex Index {get;}

            public HostCodeInstructions[] Instructions {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public int TotalCount => Instructions.Sum(x => x.TotalCount);
            
            public E Zero => Empty; 
            
            public string Description
                => $"{TotalCount} instructions decoded from {Index.EntryCount} functions provided by {Index.Hosts.Length} hosts across {Index.Parts.Length} parts";
        }        
    }
}