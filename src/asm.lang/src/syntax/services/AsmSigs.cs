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

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        const char OperandDelimiter = Chars.Comma;

        const char MnemonicTerminator = Chars.Space;

        const char CompositeIndicator = Chars.FSlash;

        Index<char> RegDigits;

        Adjacent<char, OneOf<char>> RegDigitRule;

        readonly SymbolTable<AsmSigToken> _SigOpSymbols;

        readonly SymbolTable<CompositeSigToken> _Composites;

        readonly SymbolTable<AsmMnemonicCode> _Mnemonics;

        public AsmSigs()
        {
            _SigOpSymbols = SymbolStores.table<AsmSigToken>();
            _Composites = SymbolStores.table<CompositeSigToken>();
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
            _Mnemonics = SymbolStores.table<AsmMnemonicCode>();
        }

        [MethodImpl(Inline)]
        public SymbolTable<CompositeSigToken> CompositeTokens()
            => _Composites;

        [MethodImpl(Inline)]
        public SymbolTable<AsmSigToken> SigTokens()
            => _SigOpSymbols;

        [MethodImpl(Inline)]
        public SymbolTable<AsmMnemonicCode> Mnemonics()
            => _Mnemonics;

        void ShowSymbols<T>(SymbolTable<T> src, ShowLog dst)
            where T : unmanaged
        {
            var count = src.TokenCount;
            var symbols = src.Symbols;
            var sort = typeof(T).Name;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                dst.Show(string.Format("{0,-18} | {1,-12} | {2}", sort, symbol.Name, symbol.Value));
            }
        }

        public void ShowSymbols()
        {
            using var sigs = ShowLog("sig-tokens", FS.Extensions.Csv);
            ShowSymbols(SigTokens(), sigs);

            using var monics = ShowLog("mnemonic-symbols", FS.Extensions.Csv);
            ShowSymbols(Mnemonics(), monics);

            using var composites = ShowLog("composite-symbols", FS.Extensions.Csv);
            ShowSymbols(CompositeTokens(), composites);
        }

        [Op]
        public Outcome ParseSig(AsmSigExpr src, out AsmSig dst)
        {
            dst = AsmSig.Empty;
            if(AsmSyntax.code(src.Mnemonic, out var code))
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

        public Outcome ParseOperand(string src, out AsmSigOperand dst)
        {
            if(_SigOpSymbols.TokenFromSymbol(src, out var token))
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
            if(_SigOpSymbols.IndexFromSymbol(src.Content, out var index))
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
                && Query.begins(s, DigitQualifier)
                && Query.test(s[1], Rules.oneof(RegDigits));
        }

        [Op]
        public bool IsComposite(AsmSigOperandExpr src)
            => _Composites.ContainsSymbol(src.Content);

        [Op]
        public bool IsComposite(AsmSigExpr src)
            => src.Operands.Any(IsComposite);

        public Index<AsmSigOperandExpr> OperandExpressions(string src)
            => src.Split(Chars.Comma).Map(sigop);

        [Op]
        public Index<AsmSigOperandExpr> OperandExpressions(AsmSigExpr src)
        {
            if(AsmSyntax.mnemonic(src.Content, out var monic))
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


        Index<Token<AsmSigToken>> _SigOpTokens
        {
            [MethodImpl(Inline), Op]
            get => _SigOpSymbols.Tokens;
        }

        static string format(AsmMnemonic monic, Index<AsmSigOperandExpr> operands)
        {
            var dst = text.buffer();
            render(monic, operands, dst);
            return dst.Emit();
        }

        static void render(AsmMnemonic monic, Index<AsmSigOperandExpr> operands, ITextBuffer dst)
        {
            dst.Append(monic.Format(MnemonicCase.Uppercase));
            var opcount = operands.Length;
            if(opcount != 0)
            {
                dst.Append(Chars.Space);
                dst.Append(Format.join(OperandDelimiter, operands));
            }
        }

        [MethodImpl(Inline), Op]
        static AsmSigOperandExpr sigop(string src)
            => new AsmSigOperandExpr(src.Trim());

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static Fence<char> SizeFence => (LBracket, RBracket);
    }
}