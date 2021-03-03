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
    using static AsmExpr;
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

        readonly SymbolTable<AsmSigOpKind> SigOpSymbols;

        readonly Index<Token<AsmSigOpKind>> SigOpTokens;

        readonly SymbolTable<AsmSigCompositeKind> Composites;

        public AsmSigs()
        {
            SigOpTokens = tokens();
            SigOpSymbols = SigOpTokens.ToSymbolTable();
            Composites = SymbolTables.create<AsmSigCompositeKind>();
            RegDigits = array(D0, D1, D2, D3, D4, D5, D6, D7);
            RegDigitRule = Rules.adjacent(DigitQualifier, oneof(RegDigits));
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
            if(SigOpSymbols.Index(src.Content, out var index))
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
                    var i = Query.index(src, MnemonicTerminator);
                    var operands = i > 0 ? src.Substring(i).Split(OperandDelimiter).Map(sigop) : sys.empty<SigOperand>();
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
            dst = default;
            if(text.empty(sig))
                return false;

            var i = Query.index(sig, MnemonicTerminator);
            if(i > 0)
                dst = mnemonic(Parse.segment(sig, 0, i - 1));
            else
                dst = mnemonic(sig);

            return true;
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
            return Query.contains(src.Content, CompositeIndicator);
        }

        public Index<SigOperand> Operands(string src)
            => src.Split(Chars.Comma).Map(sigop);

        [Op]
        public Index<SigOperand> Operands(Signature src)
        {
            if(ParseMnemonic(src.Content, out var monic))
                if(Parse.after(src.Content, monic.Name, out var remainder))
                    return Operands(remainder);
            return Index<SigOperand>.Empty;
        }

        [Op]
        public bool Decompose(SigOperand src, out Pair<SigOperand> dst)
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
        /// Defines a <see cref='SigOperand'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static SigOperand sigop(string src)
            => new SigOperand(src);

        [Op]
        public static bool composite(SigOperand src)
            => src.Content.Contains(CompositeIndicator);

        [Op]
        public static bool composite(Signature src)
            => src.Operands.Any(o => o.IsComposite);

        [MethodImpl(Inline), Op]
        public static AsmMnemonicCode mnemonic2(string src)
            => Enums.parse(src, AsmMnemonicCode.None);

        [MethodImpl(Inline), Op]
        public static AsmMnemonic mnemonic(string src)
            => new AsmMnemonic(src);

        public static string format(Signature src)
        {
            var buffer = text.buffer();
            buffer.Append(src.Mnemonic.Format(AsmMnemonicCase.Uppercase));
            var opcount = src.Operands.Length;
            if(opcount != 0)
            {
                buffer.Append(Chars.Space);
                buffer.Append(Format.join(OperandDelimiter, src.Operands));
            }
            return buffer.Emit();
        }

        [Op]
        public static Index<Token<AsmSigOpKind>> tokens()
        {
            var details = Enums.details<AsmSigOpKind,ushort>().View;
            var count = AsmSigOpKindFacets.IdentifierCount + 1;
            var buffer = alloc<Token<AsmSigOpKind>>(count);
            ref var dst = ref first(buffer);
            for(byte i=1; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var symbol = detail.Field.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, detail.Name);
                seek(dst,i) = Tokens.token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }
    }
}