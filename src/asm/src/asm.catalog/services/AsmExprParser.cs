//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static AsmExpr;
    using static TextRules;
    using static memory;

    [ApiHost]
    public sealed partial class AsmExprParser : WfService<AsmExprParser, AsmExprParser>
    {
        Index<char> RegDigits;

        public AsmExprParser()
        {
            RegDigits = array(Chars.D0, Chars.D1, Chars.D2, Chars.D3, Chars.D4, Chars.D5, Chars.D6, Chars.D7);
        }

        public bool Sig(AsmSigExpr src, out AsmSig dst)
        {
            dst = AsmSig.Empty;


            return false;
        }


        [Op]
        public bool Mnemonic(AsmSigExpr src, out AsmMnemonicExpr dst)
        {
            var i = Query.index(src.Text, Chars.Space);
            if(i != NotFound && i > 0)
            {
                dst = AsmExpr.mnemonic(Parse.segment(src.Text, 0, i - 1));
                return true;
            }
            else
            {
                dst = AsmMnemonicExpr.Empty;
                return false;
            }
        }

        [Op]
        public Index<AsmSigOpExpr> Operands(AsmSigExpr src)
        {
            if(Mnemonic(src, out var monic))
            {
                if(Parse.after(src.String, monic.String, out var remainder))
                {
                    var operands = remainder.SplitClean(Chars.Comma).Map(AsmExpr.sigop);
                    return operands;
                }
            }

            return sys.empty<AsmSigOpExpr>();
        }

        [Op]
        public bool IsDigit(AsmSigOpExpr src)
        {
            var s = src.String;
            return s.Length >= 2 && Query.begins(s, Chars.FSlash) && Query.test(s[1], Rules.oneof(RegDigits));
        }

        [Op]
        public bool IsComposite(AsmSigOpExpr src)
        {
            return Query.begins(src.String, Chars.FSlash) && !IsDigit(src);
        }
    }
}