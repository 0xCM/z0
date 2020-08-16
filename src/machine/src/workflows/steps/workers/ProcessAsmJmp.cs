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


    public struct ProcessAsmJmp : IJmpProcessor
    {
        readonly BitBroker<JmpKind,LocatedAsmFx> broker;
        
        public IWfContext Wf {get;}
        
        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JmpKind.JA] = DataHandlers.Create<LocatedAsmFx>(OnJA);
            broker[JmpKind.JAE] = DataHandlers.Create<LocatedAsmFx>(OnJAE);
            broker[JmpKind.JB] = DataHandlers.Create<LocatedAsmFx>(OnJB);
            broker[JmpKind.JBE] = DataHandlers.Create<LocatedAsmFx>(OnJBE);
        }

        [MethodImpl(Inline)]
        internal ProcessAsmJmp(IWfContext wf, bool connect = true) 
        {
            Wf = wf;
            broker = ProcessBrokers.jmp();
            if(connect)
                Connect();
        }

        [MethodImpl(Inline)]
        public void Process(LocatedAsmFx src)
        {
            if(src.Instruction.IsJccShortOrNear)
            {
                var kind = Enums.Parse(src.Mnemonic.ToString(),JmpKind.None);
                broker.Relay(kind,src);   
            }
        }

        [MethodImpl(Inline)]
        public void OnJA(LocatedAsmFx inxs)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(LocatedAsmFx inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJB(LocatedAsmFx inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJBE(LocatedAsmFx inxs)
        {
            term.announce();            
        }
    }
}