//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmStatementThumbprint
    {
        public AsmStatementExpr Statement {get;}

        public AsmThumbprint Thumbprint {get;}

        [MethodImpl(Inline)]
        public AsmStatementThumbprint(AsmStatementExpr expr, AsmThumbprint tp)
        {
            Statement = expr;
            Thumbprint = tp;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementThumbprint((AsmStatementExpr expr, AsmThumbprint tp) src)
            => new AsmStatementThumbprint(src.expr, src.tp);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementThumbprint(Paired<AsmStatementExpr, AsmThumbprint> src)
            => new AsmStatementThumbprint(src.Left, src.Right);
    }
}
