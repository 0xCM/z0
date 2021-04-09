//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;
    using static AsmMnemonicCode;

    partial struct AsmLang
    {
        // 22 /r            | AND r8, r/m8     | RM    | Valid       | Valid           | r8 AND r/m8.                              |
        [Op]
        public AsmExpr and(Gp8 dst, Gp8 src)
        {
            Clear();
            Render(SymSpace.Symbol(AND));
            Render(Chars.Space);
            Render(SymSpace.Symbol(dst));
            Render(Chars.Comma);
            Render(SymSpace.Symbol(src));
            return Emit();
        }


        // | 23 /r            | AND r16, r/m16   | RM    | Valid       | Valid           | r16 AND r/m16.                            |

        [Op]
        public AsmExpr and(Gp16 dst, Gp16 src)
        {
            Clear();
            Render(SymSpace.Symbol(AND));
            Render(Chars.Space);
            Render(SymSpace.Symbol(dst));
            Render(Chars.Comma);
            Render(SymSpace.Symbol(src));
            return Emit();
        }
    }
}