//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm;

    using static Konst;

    public struct JmpProcessor : IJmpProcessor
    {
        readonly BitBroker<JmpKind,LocatedInstruction> broker;
        
        public IMachineContext Context {get;}
        
        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JmpKind.JA] = DataHandlers.Create<LocatedInstruction>(OnJA);
            broker[JmpKind.JAE] = DataHandlers.Create<LocatedInstruction>(OnJAE);
            broker[JmpKind.JB] = DataHandlers.Create<LocatedInstruction>(OnJB);
            broker[JmpKind.JBE] = DataHandlers.Create<LocatedInstruction>(OnJBE);
        }

        [MethodImpl(Inline)]
        internal JmpProcessor(IMachineContext context, bool connect = true) 
        {
            Context = context;
            broker = ProcessBrokers.jmp();
            if(connect)
                Connect();
        }

        [MethodImpl(Inline)]
        public void Process(LocatedInstruction src)
        {
            if(src.Instruction.IsJccShortOrNear)
            {
                var kind = Enums.Parse(src.Mnemonic.ToString(),JmpKind.None);
                broker.Relay(kind,src);   
            }
        }

        [MethodImpl(Inline)]
        public void OnJA(LocatedInstruction inxs)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJB(LocatedInstruction inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJBE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        IDataBroker<JmpKind,LocatedInstruction> IAsmProcessor<JmpKind,LocatedInstruction>.Broker 
            => broker;
    }
}