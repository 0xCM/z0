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

        public HostInstructions Source {get;}
        
        public IDataBroker<HostHandlerKind,HostInstructions> Broker {get;}
        
        [MethodImpl(Inline)]
        public ProcessHostAsm(IWfContext context, HostInstructions src)
        {
            Wf = context;   
            Broker = DataBrokers.broker64<HostHandlerKind,HostInstructions>();
            Source = src;
            (this as IDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        void ProcessJmp(HostInstructions src)
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
        public void Process(HostInstructions src)
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