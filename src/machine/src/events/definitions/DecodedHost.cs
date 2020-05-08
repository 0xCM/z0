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
    using E = MachineEvents.DecodedHost;

    public partial class MachineEvents
    {
        public readonly struct DecodedHost : IMachineEvent<E>
        {
            public static E Empty => new E(HostInstructions.Empty);

            [MethodImpl(Inline)]
            public static DecodedHost Create(HostInstructions inxs)
                => new DecodedHost(inxs);            

            [MethodImpl(Inline)]
            public DecodedHost(HostInstructions inxs)
            {
                Instructions = inxs;
            }
            
            public HostInstructions Instructions {get;}

            public ApiHostUri Host => Instructions.Host;

            public PartId Part => Host.Owner;

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public E Zero => Empty; 
            
            public string Description
                => $"{Instructions.Count}  {Instructions.Host} instructions decoded";
        }        
    }
}