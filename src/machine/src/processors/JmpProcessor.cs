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

    public interface IJmpProcessor : IAsmProcessor<JmpKind,LocatedInstruction>
    {
        void OnJA(LocatedInstruction inxs)
        {
            term.announce();
        }

        void OnJAE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        void OnJB(LocatedInstruction inxs)
        {
            term.announce();            
        }

        void OnJBE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        void IDataProcessor.Connect()
        {
            Broker[JmpKind.JA] = DataHandlers.Create<LocatedInstruction>(OnJA);
            Broker[JmpKind.JAE] = DataHandlers.Create<LocatedInstruction>(OnJAE);
            Broker[JmpKind.JB] = DataHandlers.Create<LocatedInstruction>(OnJB);
            Broker[JmpKind.JBE] = DataHandlers.Create<LocatedInstruction>(OnJBE);
        }
    }

    public struct JmpProcessor : IJmpProcessor
    {
        public IMachineContext Context {get;}

        public IDataBroker<JmpKind,LocatedInstruction> Broker {get;}
        
        public static IDataProcessor<LocatedInstruction> Create(IMachineContext context)
        {
            var processor = new JmpProcessor(context);
            (processor as IJmpProcessor).Connect();            
            return processor;
        }

        JmpProcessor(IMachineContext context) 
        {
            Context = context;
            Broker = DataBroker64<JmpKind,LocatedInstruction>.Alloc();
        }

        public void Process(LocatedInstruction src)
        {
            if(src.Instruction.IsJccShortOrNear)
            {
                var kind = Enums.Parse(src.Mnemonic.ToString(),JmpKind.None);
                Broker.Relay(kind,src);   
            }
        }

        public void OnJA(LocatedInstruction inxs)
        {
            term.announce();
        }

        public void OnJAE(LocatedInstruction inxs)
        {
            term.announce();
            
        }

        public void OnJB(LocatedInstruction inxs)
        {
            term.announce();
            
        }

        public void OnJBE(LocatedInstruction inxs)
        {
            term.announce();
            
        }

    }
}