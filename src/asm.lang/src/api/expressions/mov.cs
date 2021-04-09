//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;
    using static memory;

    partial struct AsmLang
    {
        public AsmExpr mov(Gp64 dst, Imm64 src)
        {
            Clear();
            byte j = 0;
            Render(SymSpace.Symbol(MOV));
            Render(Chars.Space);
            Render(SymSpace.Symbol(dst));
            Render(Chars.Comma);
            Render(src);
            return Emit();
        }
    }
}