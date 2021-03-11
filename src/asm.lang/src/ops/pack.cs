//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmExprSet pack(AsmOpCodeExpr oc, AsmSig sig, AsmStatementExpr statement)
            => new AsmExprSet(oc,sig,statement);

        [Op]
        public static AsmExprSet pack(string oc, string sig, string statement)
            => new AsmExprSet(asm.opcode(oc), AsmSigParser.parse(sig), asm.statement(statement));
    }
}