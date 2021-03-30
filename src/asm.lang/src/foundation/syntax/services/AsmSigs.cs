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
    using static Pow2x16;

    using syntax = AsmSyntax;

    unsafe struct AsmSigSymbolCache
    {
        public MemoryAddress MnemonicsAddress;

        public SymbolTable<AsmMnemonicCode> Mnemonics
        {
            [MethodImpl(Inline)]
            get => @as<SymbolTable<AsmMnemonicCode>>(MnemonicsAddress.Pointer());
        }

        public SymbolTable<AsmSigToken> SigOpSymbols;

        public SymbolTable<CompositeSigToken> Composites;

        public Index<char> RegDigits;

        public Adjacent<char, OneOf<char>> RegDigitRule;

    }

    readonly struct AsmSigSymbolStorage
    {
        const char DigitQualifier = FSlash;

        [FixedAddressValueType]
        static readonly SymbolTable<AsmSigToken> SigOpSymbols;

        [FixedAddressValueType]
        static readonly SymbolTable<CompositeSigToken> Composites;

        [FixedAddressValueType]
        static readonly SymbolTable<AsmMnemonicCode> Mnemonics;

        [FixedAddressValueType]
        static readonly Index<char> RegDigits;

        [FixedAddressValueType]
        static Adjacent<char, OneOf<char>> RegDigitRule;

        public static void access(out AsmSigSymbolCache dst)
        {
            dst.MnemonicsAddress = address(Mnemonics);
            dst.SigOpSymbols = SigOpSymbols;
            dst.Composites = Composites;
            dst.RegDigits = RegDigits;
            dst.RegDigitRule = RegDigitRule;
        }

        static AsmSigSymbolStorage()
        {
            SigOpSymbols = SymbolStores.table<AsmSigToken>();
            Composites = SymbolStores.table<CompositeSigToken>();
            Mnemonics = SymbolStores.table<AsmMnemonicCode>();
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
        }
    }

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        const char OperandDelimiter = Chars.Comma;

        const char MnemonicTerminator = Chars.Space;

        const char CompositeIndicator = Chars.FSlash;

        readonly AsmSigSymbolCache Cache;

        public AsmSigs()
        {
            AsmSigSymbolStorage.access(out Cache);
        }

        void DefineSubstitutions()
        {

        }

        [MethodImpl(Inline), Op]
        public SymbolTable<CompositeSigToken> CompositeTokens()
            => Cache.Composites;

        [MethodImpl(Inline), Op]
        public SymbolTable<AsmSigToken> SigTokens()
            => Cache.SigOpSymbols;

        [MethodImpl(Inline), Op]
        public SymbolTable<AsmMnemonicCode> Mnemonics()
            => Cache.Mnemonics;

        void ShowSymbols<T>(SymbolTable<T> src, ShowLog dst)
            where T : unmanaged
        {
            var count = src.TokenCount;
            var symbols = src.Symbols;
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
            if(Cache.SigOpSymbols.TokenFromSymbol(src, out var token))
            {
                dst = new AsmSigOperand(token.Identifier, token.Kind, token.SymbolName);
                return true;
            }
            else
            {
                dst = AsmSigOperand.Empty;
                return (false, $"Cannot match symbol for the operand expression <{src}>");
            }
        }

        [MethodImpl(Inline), Op]
        public ref readonly Token<AsmSigToken> Token(AsmSigToken kind)
        {
            if((ushort)kind <= (ushort)P2ᐞ11)
                return ref _SigOpTokens[(byte)kind];
            else
                return ref _SigOpTokens[0];
        }

        [Op]
        public bool ParseToken(AsmSigOperandExpr src, out Token<AsmSigToken> token)
        {
            if(Cache.SigOpSymbols.IndexFromSymbol(src.Content, out var index))
            {
                token = _SigOpTokens[index];
                return true;
            }
            else
            {
                token = default;
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
            => Cache.Composites.ContainsSymbol(src.Content);

        [Op]
        public bool IsComposite(AsmSigExpr src)
            => src.Operands.Any(IsComposite);

        public Index<AsmSigOperandExpr> OperandExpressions(string src)
            => src.Split(Chars.Comma).Map(sigop);

        [Op]
        public Index<AsmSigOperandExpr> OperandExpressions(AsmSigExpr src)
        {
            if(syntax.mnemonic(src.Content, out var monic))
                if(Parse.after(src.Content, monic.Name, out var remainder))
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

        [Op]
        public bool ParseDigit(string src, out RegDigit dst)
        {
            dst = default;
            if(Parse.rule(src, Cache.RegDigitRule, out var result) &&
                Parse.digit(result.B, out var digit))
                    return assign(digit, out dst);
            return false;
        }

        Index<Token<AsmSigToken>> _SigOpTokens
        {
            [MethodImpl(Inline), Op]
            get => Cache.SigOpSymbols.Tokens;
        }

        [MethodImpl(Inline), Op]
        static AsmSigOperandExpr sigop(string src)
            => new AsmSigOperandExpr(src.Trim());

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static Fence<char> SizeFence => (LBracket, RBracket);
    }
}