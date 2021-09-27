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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmDirective directive(text15 name, DirectiveOperand op0 = default, DirectiveOperand op1 = default, DirectiveOperand op2 = default)
            => new AsmDirective(name,op0,op1,op2);
    }
}