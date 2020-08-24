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
            broker[JmpKind.JA] = AB.handler<BasedAsmFx>(OnJA);
            broker[JmpKind.JAE] = AB.handler<BasedAsmFx>(OnJAE);
            broker[JmpKind.JB] = AB.handler<BasedAsmFx>(OnJB);
            broker[JmpKind.JBE] = AB.handler<BasedAsmFx>(OnJBE);
        }

        [MethodImpl(Inline)]
        public ProcessAsmJmp(IWfContext wf, bool connect = true)
        {
            Wf = wf;
            broker = AsmBrokers.jmp();
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
        public void OnJA(BasedAsmFx fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(BasedAsmFx fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJB(BasedAsmFx fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJBE(BasedAsmFx fx)
        {
            term.announce();
        }
    }
}