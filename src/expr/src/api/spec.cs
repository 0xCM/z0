//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct expr
    {
        [MethodImpl(Inline), Op]
        public static OpExprSpec spec(Scope scope, Label opname, IExpr[] operands)
            => new OpExprSpec(scope,opname,operands);

        [MethodImpl(Inline), Op]
        public static ExprSpec spec(Scope scope, IExpr[] operands, IExprComposer composer)
            => new ExprSpec(scope,operands,composer);
    }
}