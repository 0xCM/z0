//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static BitFlow;

    public readonly struct AsmDirective
    {
        public readonly text15 Name;

        public readonly DirectiveOperand Op0;

        public readonly DirectiveOperand Op1;

        public readonly DirectiveOperand Op2;

        [MethodImpl(Inline)]
        public AsmDirective(text15 name, DirectiveOperand op0 = default, DirectiveOperand op1 = default, DirectiveOperand op2 = default)
        {
            Name = name;
            Op0 = op0;
            Op1 = op1;
            Op2 = op2;
        }

        public static AsmDirective Empty => new AsmDirective(EmptyString, EmptyString, EmptyString, EmptyString);
    }
}