//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;
    using SR = SymbolicRender;

    partial struct AsmParser
    {
        [Op]
        public static Outcome parse(string src, out AsmExpr dst)
        {
            dst = new AsmExpr(src.Trim());
            return true;
        }

        public static Outcome parse(ReadOnlySpan<AsciCode> src, out AsmExpr dst)
        {
            dst = AsmExpr.Empty;
            var outcome = Outcome.Success;
            var i = SP.EatWhitespace(src);
            if(i == NotFound)
                return (false,"Input was empty");

            var remainder = slice(src,i);
            i = SQ.index(remainder,AsciCode.Space);
            if(i == NotFound)
            {
                var monic = asm.mnemonic(SR.format(remainder).Trim());
                var operands = Span<char>.Empty;
                dst = asm.expr(monic,operands);
            }
            else
            {
                var monic = asm.mnemonic(SR.format(slice(remainder,0, i)).Trim());
                var operands = SR.format(slice(remainder,i)).Trim();
                dst = asm.expr(monic, operands);
            }

            return outcome;
        }

        public static Outcome parse(in AsciLine src, out AsmBlockLabel label, out AsmExpr expr)
        {
            label = AsmBlockLabel.Empty;
            var content = src.Content;
            var i = SQ.index(content, AsciCode.Colon);
            if(i < 0)
                return false;

            label = new AsmBlockLabel(SR.format(SQ.left(content, i)).Trim());
            expr = SR.format(SQ.right(content, i)).Replace(Chars.Tab,Chars.Space).Trim();

            return true;
        }
    }
}