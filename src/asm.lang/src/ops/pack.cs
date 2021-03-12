//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmExprSet pack(AsmOpCodeExpr oc, AsmSig sig, AsmStatementExpr statement)
            => new AsmExprSet(oc, sig, statement);
    }
}