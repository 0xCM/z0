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

    public readonly struct PartAsmProcessor : IAsmProcessor<AsmHandlerKind,PartAsmFx>
    {
        public IWfContext Wf {get;}

        readonly BitBroker<AsmHandlerKind,PartAsmFx> broker;

        public IWfDataBroker<AsmHandlerKind,PartAsmFx> Broker
            => broker;

        [MethodImpl(Inline)]
        public PartAsmProcessor(IWfContext wf)
        {
            Wf = wf;
            broker = DataBrokers.broker64<AsmHandlerKind,PartAsmFx>();
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process(PartAsmFx src)
        {
            for(var i=0; i<src.Length; i++)
                AsmProcessors.hosts(Wf, src[i]).Process();
        }
    }
}