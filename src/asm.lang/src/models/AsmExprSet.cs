//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmExprSet
    {
        public AsmFormExpr Form {get;}

        public AsmStatementExpr Statement {get;}

        [MethodImpl(Inline)]
        public AsmExprSet(AsmFormExpr form, AsmStatementExpr statement)
        {
            Form = form;
            Statement = statement;
        }

        public AsmOpCodeExpr OpCode
            => Form.OpCode;

        public AsmSigExpr Sig
            => Form.Sig;
    }
}