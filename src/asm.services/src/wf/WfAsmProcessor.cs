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

    public struct WfAsmProcessor : IApiAsmProcessor
    {
        public IWfShell Wf {get;}

        public IWfDataBroker<Mnemonic,ApiInstruction> Broker {get;}

        [MethodImpl(Inline)]
        public WfAsmProcessor(IWfShell context)
        {
            Wf = context;
            Broker = WfControl.broker<Mnemonic,ApiInstruction>((int)Mnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(ApiInstruction src)
        {
            Broker.Relay(src.Mnemonic, src);
        }
    }
}