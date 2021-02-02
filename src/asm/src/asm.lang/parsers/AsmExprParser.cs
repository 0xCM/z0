//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Chars;
    using static Rules;
    using static TextRules;
    using static AsmExpr;
    using static AsmOpCodeModel;

    using api = AsmExpr;

    [ApiHost]
    public sealed partial class AsmExprParser : WfService<AsmExprParser, AsmExprParser>
    {
        Index<char> RegDigits;

        Adjacent<char, OneOf<char>> RegDigitRule;

        Index<AsmSigOpIdentifier> SigOpIdentifiers;

        const char MnemonicTerminator = Chars.Space;

        const char OperandSeparator = Chars.Comma;

        const char DigitQualifier = FSlash;

        public AsmExprParser()
        {
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
            SigOpIdentifiers = api.identifiers(AsmSigOpKind.None);
        }


        [MethodImpl(Inline), Op]
        public ref readonly AsmSigOpIdentifier Identifier(AsmSigOpKind kind)
        {
            if(kind <= AsmSigOpKindFacets.LastClass)
                return ref SigOpIdentifiers[(byte)kind];
            else
                return ref SigOpIdentifiers[0];
        }

        [Op]
        public AsmSigOpKind Kind(AsmSigOpExpr src)
        {
            return SigOpIdentifiers.First.Kind;
        }

        [Op]
        public bool Mnemonic(AsmSigExpr src, out AsmMnemonicExpr dst)
        {
            var i = Query.index(src.Content, MnemonicTerminator);
            if(i != NotFound && i > 0)
            {
                dst = mnemonic(Parse.segment(src.Content, 0, i - 1));
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
                if(Parse.after(src.Content, monic.Content, out var remainder))
                    return remainder.SplitClean(OperandSeparator).Map(sigop);
            return Index<AsmSigOpExpr>.Empty;
        }

        [Op]
        public bool IsDigit(AsmSigOpExpr src)
        {
            var s = src.Content;
            return s.Length >= 2
                && Query.begins(s, DigitQualifier)
                && Query.test(s[1], Rules.oneof(RegDigits));
        }

        [Op]
        public bool IsComposite(AsmSigOpExpr src)
        {
            return Query.begins(src.Content, DigitQualifier) && !IsDigit(src);
        }

        [Op]
        public bool RegisterDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(Parse.rule(src, RegDigitRule, out var result) &&
                Parse.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }
    }
}