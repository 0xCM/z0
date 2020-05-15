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

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,LocatedInstruction>
    {
        void OnAnd(LocatedInstruction located)
        {
            
        }

        void OnOr(LocatedInstruction located)
        {
            
        }

        void IDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = DataHandlers.Create<LocatedInstruction>(OnAnd);
            Broker[Mnemonic.Or] = DataHandlers.Create<LocatedInstruction>(OnOr);
        }
    }

    struct AsmProcessor : IAsmProcessor
    {
        [MethodImpl(Inline)]
        public static IAsmProcessor Create(IMachineContext context)
        {
            var processor = new AsmProcessor(context) as IAsmProcessor;
            processor.Connect();
            return processor;
        }

        public IMachineContext Context {get;}

        public IDataBroker<Mnemonic,LocatedInstruction> Broker {get;}
        
        [MethodImpl(Inline)]
        AsmProcessor(IMachineContext context)
        {
            Context = context;
            Broker = DataBrokers.Create<Mnemonic,LocatedInstruction>((int)Mnemonic.LAST);
        }

        [MethodImpl(Inline)]
        public void Process(LocatedInstruction src)
        {
            Broker.Relay(src.Mnemonic, src);
        }
    }
}