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

        public AsmExpr Statement {get;}

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmDisassembly(Hex64 offset, AsmExpr expr, AsmHexCode code)
        {
            Offset = offset;
            Statement = expr;
            Code = code;
        }

        [MethodImpl(Inline)]
        public AsmDisassembly(Hex64 offset, AsmExpr expr)
        {
            Offset = offset;
            Statement = expr;
            Code = AsmHexCode.Empty;
        }
    }
}