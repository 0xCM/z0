//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct asm
    {
        [MethodImpl(Inline),Op]
        public static AsmThumbprint thumbprint(AsmStatementExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprint(statement, sig, opcode, encoded);

        [MethodImpl(Inline),Op]
        public static AsmThumbprint thumbprint(AsmStatementExpr statement, AsmFormExpr form, AsmHexCode encoded)
            => new AsmThumbprint(statement, form.Sig, form.OpCode, encoded);

        [MethodImpl(Inline),Op]
        public static AsmThumbprint thumbprint(in AsmApiStatement src)
            => thumbprint(src.Expression, src.Sig, src.OpCode, src.Encoded);
    }
}