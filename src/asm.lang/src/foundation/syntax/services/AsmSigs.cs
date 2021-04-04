//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static Chars;
    using static memory;
    using static Rules;
    using static TextRules;

    using syntax = AsmSyntax;

    struct AsmSigSymbolCache
    {
        const char DigitQualifier = FSlash;

        public static AsmSigSymbolCache create()
        {
            var dst = new AsmSigSymbolCache();
            dst.RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            dst.RegDigitRule = Rules.adjacent(DigitQualifier, oneof(dst.RegDigits));
            return dst;
        }


        public Index<char> RegDigits;

        public Adjacent<char, OneOf<char>> RegDigitRule;
    }

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        const char CompositeIndicator = Chars.FSlash;

        readonly AsmSigSymbolCache Cache;

        readonly Symbols<AsmMnemonicCode> MnemonicSyms;

        readonly Symbols<CompositeSigToken> Composites;

        readonly Symbols<AsmSigToken> SigOps;

        public AsmSigs()
        {
            Cache = AsmSigSymbolCache.create();
            MnemonicSyms = Symbols.cache<AsmMnemonicCode>();
            Composites = Symbols.cache<CompositeSigToken>();
            SigOps = Symbols.cache<AsmSigToken>();
        }

        void DefineSubstitutions()
        {

        }

        [MethodImpl(Inline), Op]
        public Symbols<CompositeSigToken> CompositeTokens()
            => Composites;

        [MethodImpl(Inline), Op]
        public Symbols<AsmSigToken> SigTokens()
            => SigOps;

        [MethodImpl(Inline), Op]
        public Symbols<AsmMnemonicCode> Mnemonics()
            => MnemonicSyms;

        [Op,Closures(UInt64k)]
        void ShowSymbols<T>(Symbols<T> src, ShowLog dst)
            where T : unmanaged
        {
            var count = src.Count;
            var symbols = src.View;
            for(var i=0; i<count; i++)
                dst.Show(skip(symbols,i).Format());
        }

        public void ShowSymbols()
        {
            var header = Symbols.header();
            using var sigs = ShowLog("sig-tokens", FS.Csv);
            sigs.Show(header);
            ShowSymbols(SigTokens(), sigs);

            using var monics = ShowLog("sig-mnemonics", FS.Csv);
            monics.Show(header);
            ShowSymbols(Mnemonics(), monics);

            using var composites = ShowLog("sig-composites", FS.Csv);
            composites.Show(header);
            ShowSymbols(CompositeTokens(), composites);
        }

        [Op]
        public Outcome ParseSig(AsmSigExpr src, out AsmSig dst)
        {
            dst = AsmSig.Empty;
            if(syntax.code(src.Mnemonic, out var code))
            {
                var opsource = src.Operands.View;
                var opcount = opsource.Length;
                var operands = sys.alloc<AsmSigOperand>(opcount);
                ref var optarget = ref first(operands);
                for(var i=0; i<opcount; i++)
                {
                    ref readonly var opexpr = ref skip(opsource,i);
                    var outcome = ParseOperand(opexpr.Content, out seek(optarget,i));
                    if(!outcome)
                        return outcome;

                }
                dst = new AsmSig(code, operands);
                return true;
            }
            return false;
        }

        [Op]
        public Outcome ParseSig(string src, out AsmSig dst)
        {
            var eparse = syntax.sig(src, out var expr);
            if(eparse)
            {
                return ParseSig(expr, out dst);
            }
            else
            {
                dst = AsmSig.Empty;
                return eparse;
            }
        }

        [Op]
        public Outcome ParseOperand(string src, out AsmSigOperand dst)
        {
            if(SigOps.Match(src, out var sym))
            {
                dst = new AsmSigOperand(sym.Name, sym.Kind, sym.Expression);
                return true;
            }
            else
            {
                dst = AsmSigOperand.Empty;
                return false;
            }
        }

        [Op]
        public bool IsDigit(AsmOpCodeExpr src)
        {
            var s = src.Content;
            return s.Length >= 2
                && @char(s) == DigitQualifier
                && Query.test(@char(s,1), Rules.oneof(Cache.RegDigits));
        }

        [Op]
        public bool IsComposite(AsmSigOperandExpr src)
            => Composites.Match(src.Content, out var _);

        public bool IsComposite(AsmSigExpr src)
            => src.Operands.Any(IsComposite);

        public Index<AsmSigOperandExpr> OperandExpressions(string src)
            => src.Split(Chars.Comma).Map(sigop);

        [Op]
        public Index<AsmSigOperandExpr> OperandExpressions(AsmSigExpr src)
        {
            if(syntax.mnemonic(src.Content, out var monic))
                if(text.after(src.Content, monic.Name, out var remainder))
                    return OperandExpressions(remainder);
            return Index<AsmSigOperandExpr>.Empty;
        }

        [Op]
        public bool Decompose(AsmSigOperandExpr src, out Pair<AsmSigOperandExpr> dst)
        {
            if(IsComposite(src))
            {
                var parts = src.Content.Split(CompositeIndicator);
                if(parts.Length != 2)
                    root.@throw(new Exception($"Composition logic wrong for {src.Content}"));

                var left = sigop(parts[0]);
                var right = sigop(parts[1]);
                dst = root.pair(left,right);
                return true;
            }
            dst = default;
            return false;
        }

        public static bool rule(string src, Adjacent<char, OneOf<char>> rule, out Adjacent<char> dst)
        {
            var match = rule.A;
            var candidates = rule.B.Elements.View;
            var count = candidates.Length;
            var ix = text.index(candidates, rule.A);
            if(ix != NotFound)
            {
                dst = adjacent<char>(match, skip(candidates,ix));
                return true;
            }
            dst = default;
            return false;
        }

        [Op]
        public bool ParseDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(rule(src, Cache.RegDigitRule, out var result) &&
                text.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }

        [MethodImpl(Inline), Op]
        static AsmSigOperandExpr sigop(string src)
            => new AsmSigOperandExpr(src.Trim());

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static Fence<char> SizeFence => (LBracket, RBracket);
    }
}