//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ExprSpec
    {
        public Scope Scope {get;}

        public Index<IExpr> Operands {get;}

        public IExprComposer Composer {get;}
        
        [MethodImpl(Inline)]
        public ExprSpec(Scope scope, IExpr[] operands, IExprComposer composer)
        {
            Scope = scope;
            Operands = operands;
            Composer = composer;
        }
    }
}