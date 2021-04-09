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
        // 22 /r            | AND r8, r/m8     | RM    | Valid       | Valid           | r8 AND r/m8.                              |
        [Op]
        public AsmExpr and(Gp8 dst, Gp8 src)
        {
            Clear();

            byte j = 0;

            Render(SymSpace.Symbol(AND), ref j);
            Render(Chars.Space, ref j);
            Render(SymSpace.Symbol(dst), ref j);
            Render(Chars.Comma, ref j);
            Render(SymSpace.Symbol(src), ref j);

            return slice(Buffer,0,j);
        }


        // | 23 /r            | AND r16, r/m16   | RM    | Valid       | Valid           | r16 AND r/m16.                            |

        [Op]
        public AsmExpr and(Gp16 dst, Gp16 src)
        {
            Clear();

            byte j = 0;

            Render(SymSpace.Symbol(AND), ref j);
            Render(Chars.Space, ref j);
            Render(SymSpace.Symbol(dst), ref j);
            Render(Chars.Comma, ref j);
            Render(SymSpace.Symbol(src), ref j);

            return slice(Buffer,0,j);
        }
    }
}