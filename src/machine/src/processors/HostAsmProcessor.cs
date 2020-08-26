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

    public readonly struct HostAsmProcessor : IHostAsmProcessor
    {
        public IWfContext Wf {get;}

        public HostAsmFx Source {get;}

        public IWfDataBroker<HostHandlerKind,HostAsmFx> Broker {get;}

        [MethodImpl(Inline)]
        public HostAsmProcessor(IWfContext context, HostAsmFx src)
        {
            Wf = context;
            Broker = DataBrokers.broker64<HostHandlerKind,HostAsmFx>();
            Source = src;
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        void ProcessJmp(HostAsmFx src)
        {
            var pJmp = AsmProcessors.jmp(Wf);
            for(var j=0; j<src.Length; j++)
            {
                ref readonly var member = ref src[j];

                for(var k=0; k<member.Length; k++)
                    pJmp.Process(member[k]);
            }
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