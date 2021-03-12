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
    using static AsmOpCodes;

    [ApiHost]
    public class AsmSigs : WfService<AsmSigs>
    {
        const char DigitQualifier = FSlash;

        const char OperandDelimiter = Chars.Comma;

        const char MnemonicTerminator = Chars.Space;

        const char CompositeIndicator = Chars.FSlash;

        Index<char> RegDigits;

        Adjacent<char, OneOf<char>> RegDigitRule;

        readonly SymbolTable<AsmSigOpKind> _SigOpSymbols;

        readonly Index<Token<AsmSigOpKind>> _SigOpTokens;

        readonly SymbolTable<AsmSigCompositeKind> _Composites;

        readonly SymbolTable<AsmMnemonicCode> _Mnemonics;

        [MethodImpl(Inline), Op]
        public static AsmMnemonicCode monicode(string src)
            => Enums.parse(src, AsmMnemonicCode.None);

        public AsmSigs()
        {
            _SigOpTokens = tokens();
            _SigOpSymbols = SymbolStores.table(_SigOpTokens);
            _Composites = SymbolStores.table<AsmSigCompositeKind>();
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
            _Mnemonics = SymbolStores.table<AsmMnemonicCode>();
        }

        public SymbolTable<AsmSigCompositeKind> CompositeSymbols()
            => _Composites;

        public SymbolTable<AsmSigOpKind> SigOpSymbols()
            => _SigOpSymbols;

        public SymbolTable<AsmMnemonicCode> Mnemonics()
            => _Mnemonics;

        bool MnemonicText(string sig, out string dst)
        {
            if(text.empty(sig))
            {
                dst = EmptyString;
                return false;
            }
            else
            {
                var i = Query.index(sig, MnemonicTerminator);
                if(i > 0)
                {
                    dst = Parse.segment(sig, 0, i - 1).ToLower();
                    return true;
                }
                else
                {
                    dst = sig;
                    return true;
                }
            }
        }

        [Op]
        public bool ParseMnemonicCode(string sig, out AsmMnemonicCode dst)
        {
            if(MnemonicText(sig, out var candidate))
            {
                if(_Mnemonics.TokenFromSymbol(candidate, out var code))
                {
                    dst = code.Kind;
                    return true;
                }
            }
            dst = 0;
            return false;
        }

        [Op]
        public bool ParseMnemonicCode(AsmMnemonic expr, out AsmMnemonicCode dst)
            => ParseMnemonicCode(expr.Name, out dst);

        [Op]
        public bool ParseMnemonic(string sig, out AsmMnemonic dst)
        {
            dst = AsmMnemonic.Empty;
            if(text.empty(sig))
                return false;

            if(MnemonicText(sig, out var candidate))
            {
                dst = new AsmMnemonic(candidate);
                return true;
            }
            else
                return false;
        }

        [Op]
        public bool ParseSig(string src, out AsmSig dst)
        {
            if(text.nonempty(src))
            {
                if(ParseMnemonic(src, out var monic))
                {
                    var i = Query.index(src, MnemonicTerminator);
                    var operands = i > 0 ? src.Substring(i).Split(OperandDelimiter).Map(asm.sigop) : sys.empty<AsmSigOperand>();
                    dst = new AsmSig(monic, operands);
                    return true;
                }
            }
            dst = AsmSig.Empty;
            return false;
        }

        [Op]
        public AsmSig ParseSig(string src)
        {
            if(ParseSig(src, out var dst))
                return dst;
            else
                return AsmSig.Empty;
        }

        [MethodImpl(Inline), Op]
        public ref readonly Token<AsmSigOpKind> Token(AsmSigOpKind kind)
        {
            if((ushort)kind <= AsmSigOpKindFacets.LastClass)
                return ref _SigOpTokens[(byte)kind];
            else
                return ref _SigOpTokens[0];
        }

        [Op]
        public bool ParseToken(AsmSigOperand src, out Token<AsmSigOpKind> token)
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
        public bool IsComposite(AsmSigOperand src)
            => _Composites.ContainsSymbol(src.Content);

        [Op]
        public bool IsComposite(AsmSig src)
            => src.Operands.Any(IsComposite);

        public Index<AsmSigOperand> Operands(string src)
            => src.Split(Chars.Comma).Map(sigop);

        [Op]
        public Index<AsmSigOperand> Operands(AsmSig src)
        {
            if(ParseMnemonic(src.Content, out var monic))
                if(Parse.after(src.Content, monic.Name, out var remainder))
                    return Operands(remainder);
            return Index<AsmSigOperand>.Empty;
        }

        [Op]
        public bool Decompose(AsmSigOperand src, out Pair<AsmSigOperand> dst)
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

        /// <summary>
        /// Defines a <see cref='AsmSigOperand'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static AsmSigOperand sigop(string src)
            => new AsmSigOperand(src);

        public static string format(AsmSig src)
        {
            var buffer = text.buffer();
            buffer.Append(src.Mnemonic.Format(AsmMnemonicCase.Uppercase));
            var opcount = src.Operands.Length;
            if(opcount != 0)
                buffer.Append(Format.join(OperandDelimiter, src.Operands));
            return buffer.Emit();
        }

        [Op]
        public static Index<Token<AsmSigOpKind>> tokens()
        {
            var symbols = SymbolStores.table<AsmSigOpKind>();
            return symbols.Tokens;

        }
    }
}