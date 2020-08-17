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
        readonly BitBroker<JmpKind,BasedAsmFx> broker;
        
        public IWfContext Wf {get;}
        
        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JmpKind.JA] = DataHandlers.Create<BasedAsmFx>(OnJA);
            broker[JmpKind.JAE] = DataHandlers.Create<BasedAsmFx>(OnJAE);
            broker[JmpKind.JB] = DataHandlers.Create<BasedAsmFx>(OnJB);
            broker[JmpKind.JBE] = DataHandlers.Create<BasedAsmFx>(OnJBE);
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
        public void Process(BasedAsmFx src)
        {
            if(src.Instruction.IsJccShortOrNear)
            {
                var kind = Enums.Parse(src.Mnemonic.ToString(),JmpKind.None);
                broker.Relay(kind,src);   
            }
        }

        [MethodImpl(Inline)]
        public void OnJA(BasedAsmFx inxs)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(BasedAsmFx inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJB(BasedAsmFx inxs)
        {
            term.announce();            
        }

        [MethodImpl(Inline)]
        public void OnJBE(BasedAsmFx inxs)
        {
            term.announce();            
        }
    }
}