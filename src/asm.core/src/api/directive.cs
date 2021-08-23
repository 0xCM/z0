//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static Directive directive(DirectiveKind kind, DirectiveOp op0 = default, DirectiveOp op1 = default, DirectiveOp op2 = default)
            => new Directive(kind,op0,op1,op2);
    }
}