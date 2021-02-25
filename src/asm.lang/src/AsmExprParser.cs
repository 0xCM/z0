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
    using static AsmOpCodes;

    [ApiHost]
    public sealed class AsmExprParser : WfService<AsmExprParser>
    {
        Index<char> RegDigits;

        Adjacent<char, OneOf<char>> RegDigitRule;

        Index<Token<AsmSigOpKind>> SigOpTokens;

        SymbolTable<AsmSigOpKind> SigOpLookup;

        SeqSplit<char> SigOpSplitRule;

        const char DigitQualifier = FSlash;

        public AsmExprParser()
        {
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
            SigOpTokens = AsmSigs.tokens();
            SigOpLookup = SymbolTables.create(SigOpTokens);
            SigOpSplitRule = Rules.splitter(AsmExprFacets.OperandDelimiter);
        }

        [MethodImpl(Inline), Op]
        public ref readonly Token<AsmSigOpKind> Token(AsmSigOpKind kind)
        {
            if(kind <= AsmSigOpKindFacets.LastClass)
                return ref SigOpTokens[(byte)kind];
            else
                return ref SigOpTokens[0];
        }

        [Op]
        public bool ParseToken(SigOperand src, out Token<AsmSigOpKind> token)
        {
            if(SigOpLookup.Index(src.Content, out var index))
            {
                token = SigOpTokens[index];
                return true;
            }
            else
            {
                token = default;
                return false;
            }
        }

        [Op]
        public bool ParseSig(string src, out Signature dst)
        {
            if(text.nonempty(src))
            {
                if(ParseMnemonic(src, out var monic))
                {
                    var i = Query.index(src, AsmExprFacets.MnemonicTerminator);
                    var operands = i > 0 ? src.Substring(i).Split(SigOpSplitRule.Delimiter).Map(AsmSigs.sigop) : sys.empty<SigOperand>();
                    dst = new Signature(monic, operands);
                    return true;
                }
            }
            dst = Signature.Empty;
            return false;
        }

        [Op]
        public bool ParseMnemonic(string sig, out AsmMnemonic dst)
        {
            dst = AsmMnemonic.Empty;
            if(text.empty(sig))
                return false;

            var i = Query.index(sig, AsmExprFacets.MnemonicTerminator);
            if(i > 0)
                dst = mnemonic(Parse.segment(sig, 0, i - 1));
            else
                dst = mnemonic(sig);

            return true;
        }

        [Op]
        public bool ParseAddress(string src, out MemoryAddress dst)
        {
            dst = HexScalarParser.Service.Parse(src,ulong.MaxValue);
            return dst != ulong.MaxValue;
        }

        public Index<SigOperand> Operands(string src)
            => Transform.apply(SigOpSplitRule, src).Map(AsmSigs.sigop);

        [Op]
        public Index<SigOperand> Operands(Signature src)
        {
            if(ParseMnemonic(src.Content, out var monic))
                if(Parse.after(src.Content, monic.Name, out var remainder))
                    return Operands(remainder);
            return Index<SigOperand>.Empty;
        }

        [Op]
        public bool IsDigit(OpCode src)
        {
            var s = src.Content;
            return s.Length >= 2
                && Query.begins(s, DigitQualifier)
                && Query.test(s[1], Rules.oneof(RegDigits));
        }

        [Op]
        public bool IsComposite(SigOperand src)
        {
            return Query.contains(src.Content, AsmExprFacets.CompositeIndicator);
        }

        [Op]
        public bool Decompose(SigOperand src, out Pair<SigOperand> dst)
        {
            if(IsComposite(src))
            {
                var parts = src.Content.Split(AsmExprFacets.CompositeIndicator);
                if(parts.Length != 2)
                    root.@throw(new Exception($"Composition logic wrong for {src.Content}"));

                var left = AsmSigs.sigop(parts[0]);
                var right = AsmSigs.sigop(parts[1]);
                dst = root.pair(left,right);
                return true;
            }
            dst = default;
            return false;
        }

        [Op]
        public bool ParseDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(Parse.rule(src, RegDigitRule, out var result) &&
                Parse.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }
    }
}