//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    public struct ApiAsmProcessor : IApiAsmProcessor
    {
        public IWfShell Wf {get;}

        public IWfDataBroker<IceMnemonic,ApiInstruction> Broker {get;}

        [MethodImpl(Inline)]
        public ApiAsmProcessor(IWfShell wf)
        {
            Wf = wf;
            Broker = WfBrokers.create<IceMnemonic,ApiInstruction>((int)IceMnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(ApiInstruction src)
            => Broker.Relay(src.Mnemonic, src);
    }
}