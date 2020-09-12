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

    public readonly struct PartAsmProcessor : IAsmDataProcessor<AsmHandlerKind,PartAsmInstructions>
    {
        public IWfShell Wf {get;}

        readonly BitBroker<AsmHandlerKind,PartAsmInstructions> broker;

        public IWfDataBroker<AsmHandlerKind,PartAsmInstructions> Broker
            => broker;

        [MethodImpl(Inline)]
        public PartAsmProcessor(IWfShell wf)
        {
            Wf = wf;
            broker = BitBrokers.broker64<AsmHandlerKind,PartAsmInstructions>();
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process(PartAsmInstructions src)
        {
            for(var i=0; i<src.Length; i++)
                AsmProcessors.hosts(Wf, src[i]).Process();
        }
    }
}