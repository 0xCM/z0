//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOperand
    {
        public AsmOpClass Class {get;}

        public AsmOperandExpr Name {get;}

        [MethodImpl(Inline)]
        public AsmOperand(AsmOpClass @class, AsmOperandExpr name)
        {
            Class = @class;
            Name = name;
        }
    }
}