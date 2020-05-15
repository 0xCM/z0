//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public enum HostHandlerKind : byte
    {
        A = 0,

        B = 1,

        C = 2
    }

    public interface IHostProcessor : IAsmProcessor<HostHandlerKind,HostInstructions>
    {

    }

    public readonly struct HostProcessor : IHostProcessor
    {
        [MethodImpl(Inline)]
        public static IHostProcessor Create(IMachineContext context)
            => new HostProcessor(context);

        public IMachineContext Context {get;}

        public IDataBroker<HostHandlerKind,HostInstructions> Broker {get;}

        [MethodImpl(Inline)]
        HostProcessor(IMachineContext context)
        {
            Context = context;   
            Broker = DataBroker64<HostHandlerKind,HostInstructions>.Alloc();
            (this as IDataProcessor).Connect();
        }

        void ProcessJmp(HostInstructions src)
        {
            var pJmp = JmpProcessor.Create(Context);
            for(var j=0; j<src.Length; j++)
            {
                ref readonly var member = ref src[j];

                for(var k=0; k<member.Length; k++)
                    pJmp.Process(member[k]);                    
            }

        }

        public void Process(HostInstructions src)
        {
            var processor = AsmProcessor.Create(Context);
            for(var j=0; j<src.Length; j++)
            {
                ref readonly var member = ref src[j];

                for(var k=0; k<member.Length; k++)
                    processor.Process(member[k]);                    
            }
        }
    }
}