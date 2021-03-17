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
        public static AsmThumbprint thumbprint(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => new AsmThumbprint(sig, opcode, encoded);

        [MethodImpl(Inline), Op]
        public static AsmStatementThumbprint thumbprint(MemoryAddress @base, Address16 offset, AsmStatementExpr expr, AsmThumbprint thumbprint)
            => new AsmStatementThumbprint(@base, offset, expr, thumbprint);
    }
}