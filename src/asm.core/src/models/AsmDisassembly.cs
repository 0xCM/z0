//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmDisassembly
    {
        public Hex64 Offset {get;}

        public AsmStatementExpr Statement {get;}

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmDisassembly(Hex64 offset, AsmStatementExpr expr, AsmHexCode code)
        {
            Offset = offset;
            Statement = expr;
            Code = code;
        }
    }
}