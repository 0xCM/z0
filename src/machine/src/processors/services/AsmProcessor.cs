//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Asm;

    using static Seed;
    using static Memories;

    public struct AsmProcessor : IAsmProcessor
    {
        public IMachineContext Context {get;}

        public IDataBroker<Mnemonic,LocatedInstruction> Broker {get;}
        
        [MethodImpl(Inline)]
        internal AsmProcessor(IMachineContext context)
        {
            Context = context;
            Broker = DataBrokers.broker<Mnemonic,LocatedInstruction>((int)Mnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(LocatedInstruction src)
        {
            Broker.Relay(src.Mnemonic, src);
        }
    }
}