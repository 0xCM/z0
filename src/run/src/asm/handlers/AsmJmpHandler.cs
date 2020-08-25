//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Z0.Asm;

    using static Konst;

    public readonly struct AsmJmpHandler
    {
        public IWfContext Wf {get;}

        readonly BitBroker<JmpKind,BasedAsmFx> broker;

        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JmpKind.JA] = AB.handler<BasedAsmFx>(OnJA);
            broker[JmpKind.JAE] = AB.handler<BasedAsmFx>(OnJAE);
            broker[JmpKind.JB] = AB.handler<BasedAsmFx>(OnJB);
            broker[JmpKind.JBE] = AB.handler<BasedAsmFx>(OnJBE);
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