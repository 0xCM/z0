//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmRegs
    {
        public struct rflags : IRegister<rflags,W64,RFlagKind>, IRegOp64<RFlagKind>
        {
            public RFlagKind Content  {get; private set;}

            public RegisterKind RegKind => RegisterKind.RFLAGS;

            public bit CF
            {
                [MethodImpl(Inline)]
                get => gbits.testbit(Content, RFlagIndex.CF);

                [MethodImpl(Inline)]
                set => Content = gbits.setbit(Content, RFlagIndex.CF, value);
            }

            public bit PF
            {
                [MethodImpl(Inline)]
                get => gbits.testbit(Content, RFlagIndex.PF);

                [MethodImpl(Inline)]
                set => Content = gbits.setbit(Content, RFlagIndex.PF, value);
            }
        }
    }
}