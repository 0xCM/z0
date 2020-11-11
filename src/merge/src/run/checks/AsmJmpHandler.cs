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
        public IWfShell Wf {get;}

        readonly BitBroker<JccKind,ApiInstruction> broker;

        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JccKind.JA] = WfBrokers.handler<ApiInstruction>(OnJA);
            broker[JccKind.JAE] = WfBrokers.handler<ApiInstruction>(OnJAE);
            broker[JccKind.JB] = WfBrokers.handler<ApiInstruction>(OnJB);
            broker[JccKind.JBE] = WfBrokers.handler<ApiInstruction>(OnJBE);
        }

        [MethodImpl(Inline)]
        public void OnJA(ApiInstruction fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJAE(ApiInstruction fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJB(ApiInstruction fx)
        {
            term.announce();
        }

        [MethodImpl(Inline)]
        public void OnJBE(ApiInstruction fx)
        {
            term.announce();
        }
    }
}