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

    public readonly struct HostAsmProcessor : IAsmProcessor<AsmHandlerKind,HostAsmFx>
    {
        public IWfShell Wf {get;}

        public HostAsmFx Source {get;}

        public IWfDataBroker<AsmHandlerKind,HostAsmFx> Broker {get;}

        [MethodImpl(Inline)]
        public HostAsmProcessor(IWfShell context, HostAsmFx src)
        {
            Wf = context;
            Broker = BitBrokers.broker64<AsmHandlerKind,HostAsmFx>();
            Source = src;
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process()
        {
            var processor = AsmProcessors.create(Wf);
            for(var j=0; j<Source.Length; j++)
            {
                ref readonly var member = ref Source[j];
                for(var k=0; k<member.Length; k++)
                    processor.Process(member[k]);
            }
        }

        [MethodImpl(Inline)]
        public void Process(HostAsmFx src)
        {
            var processor = AsmProcessors.create(Wf);
            for(var j=0; j<Source.Length; j++)
            {
                ref readonly var member = ref src[j];
                for(var k=0; k<member.Length; k++)
                    processor.Process(member[k]);
            }
        }
    }
}