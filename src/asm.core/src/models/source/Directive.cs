//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Directive
    {
        public DirectiveKind Kind {get;}

        public DirectiveOp Op0 {get;}

        public DirectiveOp Op1 {get;}

        public DirectiveOp Op2 {get;}

        [MethodImpl(Inline)]
        public Directive(DirectiveKind kind, DirectiveOp op0 = default, DirectiveOp op1 = default, DirectiveOp op2 = default)
        {
            Kind = kind;
            Op0 = op0;
            Op1 = op1;
            Op2 = op2;
        }
    }
}