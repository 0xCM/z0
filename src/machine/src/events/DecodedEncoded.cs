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
    using E = MachineEvents.DecodedEncoded;

    public partial class MachineEvents
    {
        public readonly struct DecodedEncoded : IMachineEvent<E>
        {
            public static E Empty => new E(UriCodeIndex.Empty, UriCodeInstructions.Empty);

            [MethodImpl(Inline)]
            public static DecodedEncoded Create(UriCodeIndex index, UriCodeInstructions inxs)
                => new DecodedEncoded(index, inxs);            

            [MethodImpl(Inline)]
            public DecodedEncoded(UriCodeIndex index, UriCodeInstructions inxs)
            {
                Index = index;
                Instructions = inxs;
            }
            
            public UriCodeIndex Index {get;}

            public UriCodeInstructions Instructions {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public E Zero => Empty; 
            
            public string Description
                => $"{Instructions.Length} instructions decoded from {Index.EntryCount} functions";
        }        
    }
}