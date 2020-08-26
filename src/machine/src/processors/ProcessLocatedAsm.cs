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

        public IWfDataBroker<Mnemonic,BasedAsmFx> Broker {get;}

        [MethodImpl(Inline)]
        internal ProcessLocatedAsm(IWfContext context)
        {
            Wf = context;
            Broker = DataBrokers.broker<Mnemonic,BasedAsmFx>((int)Mnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(BasedAsmFx src)
        {
            Broker.Relay(src.Mnemonic, src);
        }
    }
}