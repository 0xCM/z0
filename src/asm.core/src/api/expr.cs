//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmExpr expr(string src)
        {
            var body = src.Trim();
            var i = text.index(body, Chars.Space);
            if(i>0)
            {
                var monic = text.left(body,i);
                var operands = text.right(body,i).Trim();
                return new AsmExpr(string.Format("{0} {1}", monic, operands));
            }
            return new AsmExpr(body);
        }

        [Op]
        public static AsmExpr expr(AsmMnemonic monic, ReadOnlySpan<char> operands)
            => new AsmExpr(string.Format("{0} {1}", monic.Format(MnemonicCase.Lowercase), text.format(operands)));
    }
}