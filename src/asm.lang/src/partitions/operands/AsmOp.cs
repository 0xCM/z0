//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOp : IAsmOp<AsmOpContent>
    {
        public AsmOpKind OpKind {get;}

        public AsmOpContent Content {get;}

        [MethodImpl(Inline)]
        public AsmOp(AsmOpKind kind, AsmOpContent content)
        {
            OpKind = kind;
            Content = content;
        }
    }
}