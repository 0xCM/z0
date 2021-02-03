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

        Index<AsmSigOpToken> SigOpTokens;

        SymbolTable<AsmSigOpToken> SigOpLookup;

        SeqSplit<char> SigOpSplitRule;

        const char MnemonicTerminator = Chars.Space;

        const char OperandSeparator = Comma;

        const char DigitQualifier = FSlash;

        const char CompoundSignifier = FSlash;

        public AsmExprParser()
        {
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
            SigOpTokens = api.SigOpTokens();
            SigOpLookup = SymbolTables.create(SigOpTokens, t => t.Symbol);
            SigOpSplitRule = Rules.splitter(OperandSeparator);
        }

        [MethodImpl(Inline), Op]
        public ref readonly AsmSigOpToken Token(AsmSigOpKind kind)
        {
            if(kind <= AsmSigOpKindFacets.LastClass)
                return ref SigOpTokens[(byte)kind];
            else
                return ref SigOpTokens[0];
        }

        [Op]
        public ref readonly AsmSigOpToken ParseSigOp(AsmSigOpExpr src)
        {
            if(SigOpLookup.Index(src.Content, out var index))
                return ref SigOpTokens[index];
            else
                return ref SigOpTokens[0];
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

        public Index<AsmSigOpExpr> Operands(string src)
            => Transform.apply(SigOpSplitRule, src).Map(sigop);

        [Op]
        public Index<AsmSigOpExpr> Operands(AsmSigExpr src)
        {
            if(Mnemonic(src, out var monic))
                if(Parse.after(src.Content, monic.Content, out var remainder))
                    return Operands(remainder);
            return Index<AsmSigOpExpr>.Empty;
        }

        [Op]
        public bool IsDigit(AsmOpCodeExpr src)
        {
            var s = src.Content;
            return s.Length >= 2
                && Query.begins(s, DigitQualifier)
                && Query.test(s[1], Rules.oneof(RegDigits));
        }

        [Op]
        public bool IsComposite(AsmSigOpExpr src)
        {
            return Query.contains(src.Content, CompoundSignifier);
        }

        [Op]
        public bool Decompose(AsmSigOpExpr src, out Pair<AsmSigOpExpr> dst)
        {
            if(IsComposite(src))
            {
                var parts = src.Content.Split(CompoundSignifier);
                if(parts.Length != 2)
                    root.@throw(new Exception($"Composition logic wrong for {src.Content}"));

                var left = api.sigop(parts[0]);
                var right = api.sigop(parts[1]);
                dst = root.pair(left,right);
                return true;
            }
            dst = default;
            return false;
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