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

    public struct ProcessLocatedAsm : IAsmProcessor
    {
        public IWfContext Wf {get;}

        public IDataBroker<Mnemonic,LocatedInstruction> Broker {get;}
        
        [MethodImpl(Inline)]
        internal ProcessLocatedAsm(IWfContext context)
        {
            Wf = context;
            Broker = DataBrokers.broker<Mnemonic,LocatedInstruction>((int)Mnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(LocatedInstruction src)
        {
            Broker.Relay(src.Mnemonic, src);
        }
    }
}