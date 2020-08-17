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

    public readonly struct ProcessHostAsm : IHostProcessor
    {
        public IWfContext Wf {get;}

        public HostAsmFx Source {get;}
        
        public IDataBroker<HostHandlerKind,HostAsmFx> Broker {get;}
        
        [MethodImpl(Inline)]
        public ProcessHostAsm(IWfContext context, HostAsmFx src)
        {
            Wf = context;   
            Broker = DataBrokers.broker64<HostHandlerKind,HostAsmFx>();
            Source = src;
            (this as IDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        void ProcessJmp(HostAsmFx src)
        {
            var pJmp = Processors.jmp(Wf);
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
            var processor = Processors.Asm(Wf);
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
            var processor = Processors.Asm(Wf);
            for(var j=0; j<Source.Length; j++)
            {
                ref readonly var member = ref src[j];
                for(var k=0; k<member.Length; k++)
                    processor.Process(member[k]);                    
            }
        }
    }
}