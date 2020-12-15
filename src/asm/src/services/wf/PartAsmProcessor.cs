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

    public readonly struct PartAsmProcessor : IWfDataProcessor<AsmHandlerKind,ApiPartRoutines>
    {
        public IWfShell Wf {get;}

        readonly BitBroker<AsmHandlerKind,ApiPartRoutines> broker;

        public IWfDataBroker<AsmHandlerKind,ApiPartRoutines> Broker
            => broker;

        [MethodImpl(Inline)]
        public PartAsmProcessor(IWfShell wf)
        {
            Wf = wf;
            broker = BitFields.broker64<AsmHandlerKind,ApiPartRoutines>();
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process(ApiPartRoutines src)
        {
            uint count = src.HostCount;
            for(var i=0u; i<count; i++)
                AsmProcessors.hosts(Wf, src[i]).Process();
        }
    }
}