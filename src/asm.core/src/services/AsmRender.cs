//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static Chars;
    using static core;

    [ApiHost]
    public readonly struct AsmRender
    {
        const char Open = Chars.LBracket;

        const string Sep = " | ";

        const char Close = Chars.RBracket;

        const string To = " => ";

        public static string format(in AsmSig src)
        {
            var dst = text.buffer();
            render(src, dst);
            return dst.Emit();
        }

        public static uint render(in AsmMnemonic src, MnemonicCase @case, ref uint i, Span<char> dst)
        {
            if(src.IsEmpty)
                return 0;
            var i0 = i;
            var data = src.Data;
            switch(@case)
            {
                case MnemonicCase.Lowercase:
                    SymbolicTools.lowercase(ref i, data, dst);
                break;
                case MnemonicCase.Uppercase:
                    SymbolicTools.uppercase(ref i, data, dst);
                break;
                case MnemonicCase.Captialized:
                    SymbolicTools.lowercase(ref i, data, dst);
                    seek(dst, i0) = skip(data,0).ToUpper();
                break;

            }

            return i - i0;
        }

        [Op]
        public static string format(in AsmMnemonic src, MnemonicCase @case)
        {
            var data = src.Data;
            var count = data.Length;
            if(count == 0)
                return EmptyString;

            Span<char> dst = stackalloc char[count];
            var i=0u;
            render(src, @case, ref i, dst);
            return text.format(dst);
        }

        public static void render(in AsmSig src, ITextBuffer dst)
        {
            var operands = src.Operands.View;
            var count = operands.Length;
            var monic = src.Mnemonic;
            dst.AppendFormat("{0} ", monic.Format(MnemonicCase.Lowercase));
            for(var i=0; i<count; i++)
            {
                dst.Append(skip(operands,i).Expr.Format());
                if(i != count - 1)
                    dst.Append(Chars.Comma);
            }
        }

        [Op]
        public static uint render(in AsmHexCode src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var count = src.Size;
            var bytes = src.Bytes;
            for(var j=0; j<count; j++)
            {
                ref readonly var b = ref skip(bytes, j);
                Hex.render(LowerCase, (Hex8)b, ref i, dst);
                if(j != count - 1)
                    seek(dst, i++) = Chars.Space;
            }
            return i - i0;
        }

        [Op]
        public static string bits(RexPrefix src)
            => text.format(BitRender.render(n8, n4, src.Code));

        [Op]
        public static string bitfield(RexPrefix src)
            => string.Format(RexFieldPattern, src.W, src.R, src.X, src.B);

        public static string describe(RexPrefix src)
            => $"{src.Code.FormatAsmHex()} | [{bits(src)}] => {bitfield(src)}";

        [Op]
        public static uint bits(Vsib src, Span<char> dst)
        {
            var i=0u;
            seek(dst,i++) = Open;
            BitNumbers.render(src.SS, ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Index, ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Base, ref i, dst);
            seek(dst,i++) = Close;
            return i;
        }

        public static void bitfield(ModRm src, ITextBuffer dst)
        {
            dst.Append(Open);

            dst.Append("ModRM.mod");
            dst.Append(Chars.Colon);
            dst.Append(src.Mod.Format());

            dst.Append(Sep);

            dst.Append("ModRM.reg");
            dst.Append(Chars.Colon);
            dst.Append(src.Reg.Format());

            dst.Append(Sep);

            dst.Append("ModRM.r/m");
            dst.Append(Chars.Colon);
            dst.Append(src.Rm.Format());

            dst.Append(Close);
        }

        public static uint bitfield(ModRm src, Span<char> dst)
        {
            const string ModRM = "ModRM";
            const string Mod = "mod";
            const string Reg = "reg";
            const string Rm = "r/m";
            var i=0u;
            copy(ModRM, ref i, dst);
            seek(dst, i++) = Open;

            copy(Mod, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n2, src.Mod, ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;

            copy(Reg, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n3, src.Reg, ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;

            copy(Rm, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n3, src.Rm, ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Close;
            return i;
        }

        static void copy(ReadOnlySpan<char> src,ref uint i, Span<char> dst)
            => SymbolicTools.copy(src, ref i, dst);

        [Op]
        public static byte format(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = asm.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.asmcomment(src.Uri, src.CodeBlock);
            seek(dst, i++) = asm.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = asm.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            seek(dst, i++) = src.Separator;
            return i;
        }

        public static string format(in AsmSourceLine src)
        {
            if(src.Label.IsNonEmpty)
                return string.Format("{0}:", src.Label.Name);
            else if(src.Statement.IsNonEmpty)
            {
                if(src.Comment.IsNonEmpty)
                    return string.Format("{0,-46} ; {1}", src.Statement, src.Comment.Content);
                else
                    return src.Statement.Format();
            }
            else if(src.Comment.IsNonEmpty)
            {
                return string.Format("; {0}", src.Comment.Content);
            }
            else
                return EmptyString;
        }

        [Op]
        public static void render(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config, ITextBuffer dst)
        {
            const string AbsolutePattern = "{0} {1} {2}";
            const string RelativePattern = "{0} {1}";

            var label = asm.label(w16, src.Offset);
            var address = @base + src.Offset;

            if(config.AbsoluteLabels)
                dst.Append(string.Format(AbsolutePattern, address.Format(), label.Format(), src.Statement.FormatPadded()));
            else
                dst.Append(string.Format(RelativePattern, label.Format(), src.Statement.FormatPadded()));

            dst.Append(asm.comment(format(src.AsmForm, src.Encoded, config.FieldDelimiter)));
        }

        [Op]
        public static string format(in AsmThumbprint src)
            => string.Format("{0} ; ({1})<{2}>[{3}] => {4}", src.Statement.FormatPadded(), src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());

        [Op]
        public static string format(AsmFormExpr src, byte[] encoded, string sep)
            => string.Format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHex());

        [Op]
        public static string thumbprint(in AsmThumbprint src, bool bitstring)
        {
            var common = format(src);
            if(bitstring)
                return string.Format("{0} => {1}", common, AsmBitstrings.format(src.Encoded));
            else
                return common;
        }

        [Op]
        public static uint render(in AsmEncodingInfo src, bool expression, bool asmsig, bool opcode, bool hex, bool bits, Span<char> dst)
        {
            var counter = 0u;
            const byte ExprPadWidth = 46;
            const sbyte ExprPad = -ExprPadWidth;

            if(expression)
            {
                var content = span(string.Format("{0} ; ", src.Statement.FormatPadded(ExprPad)));
                for(var i=0; i<content.Length; i++)
                    seek(dst,counter++) = skip(content,i);
            }

            if(asmsig)
            {
                var content = span(string.Format("({0})",src.Sig.Format()));
                for(var i=0; i<content.Length; i++)
                    seek(dst,counter++) = skip(content,i);
            }

            if(opcode)
            {
                var content = span(string.Format("<{0}>", src.OpCode.Format()));
                for(var i=0; i<content.Length; i++)
                    seek(dst,counter++) = skip(content,i);

            }

            if(hex)
            {
                var content = span(string.Format("[{0}] => {1}", src.Encoded.Size,  src.Encoded.Format()));
                for(var i=0; i<content.Length; i++)
                    seek(dst,counter++) = skip(content,i);
            }

            if(bits)
            {
                var _to = span(To);
                for(var i=0; i<To.Length; i++)
                    seek(dst,counter++) = skip(_to,i);

                counter += AsmBitstrings.render(n8, n4, src.Encoded, counter, dst);
            }

            return counter;
        }

        [Op]
        public static string thumbprint(in AsmEncodingInfo src)
        {
            var bits = AsmBitstrings.format(src.Encoded);
            var statement = string.Format("{0} ; ({1})<{2}>[{3}] => {4}", src.Statement.FormatPadded(), src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());
            return string.Format("{0} => {1}", statement, AsmBitstrings.format(src.Encoded));
        }

        [Op]
        public static string format(AsmMnemonic monic, Index<AsmSigOperandExpr> operands)
        {
            var dst = text.buffer();
            render(monic, operands, dst);
            return dst.Emit();
        }

        [Op]
        public static void render(AsmMnemonic monic, Index<AsmSigOperandExpr> operands, ITextBuffer dst)
        {
            dst.Append(monic.Format(MnemonicCase.Uppercase));
            var opcount = operands.Length;
            if(opcount != 0)
            {
                dst.Append(Chars.Space);
                dst.Append(text.join(Chars.Comma, operands));
            }
        }

        [Op]
        public static string format(Sib src)
        {
            var dst = text.buffer();
            dst.Append(src.Base.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Index.Format());
            dst.Append(Chars.Space);
            dst.Append(src.Scale.Format());
            return dst.ToString();
        }

        [Op]
        public static string format(in AsmBranchInfo src)
            => string.Concat(src.Source, " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        [Op]
        public static string format(in ImmInfo src)
            => string.Concat(src.Value.FormatHex(zpad:false, prespec:false));

        [Op]
        public static string format(in AsmDx src)
            => (src.Size switch{
                AsmDisplacementSize.y1 => ((byte)src.Value).FormatHex(HexSpec),
                AsmDisplacementSize.y2 => ((ushort)src.Value).FormatHex(HexSpec),
                AsmDisplacementSize.y4 => ((uint)src.Value).FormatHex(HexSpec),
                _ => (src.Value).FormatHex(HexSpec),
            }) + "dx";


        static HexFormatOptions HexSpec
        {
            [MethodImpl(Inline), Op]
            get => HexFormatSpecs.options(zpad:false, specifier:false);
        }

        [Op]
        public static string offset(ulong offset, DataWidth width)
            => width switch{
                DataWidth.W8 => ScalarCast.uint8(offset).FormatAsmHex(),
                DataWidth.W16 => ScalarCast.uint16(offset).FormatAsmHex(),
                DataWidth.W32 => ScalarCast.uint32(offset).FormatAsmHex(),
                DataWidth.W64 => offset.FormatAsmHex(),
                _ => EmptyString
            };

        [Op]
        public static string format(in AsmCallSite src)
            => string.Format("{0}:{1}", src.Caller, src.LocalOffset);

        [Op]
        public static string format(AsmFormExpr src)
            => string.Format("({0})<{1}>", src.Sig, src.OpCode);
        [Op]
        public static string format(in AsmCaller src)
            => string.Format("{0} {1}", src.Base, src.Identity);

        [Op]
        public static string format(in AsmCallee src)
            => string.Concat(src.Base.Format(), Colon, Chars.Space, src.Identity);

        [Op]
        public static string format(in AsmCallInfo src)
            => string.Format("{0} -> {2}", src.CallSite, src.Target);

        [Op]
        public static string format(in CallRel32 src)
            => string.Format("{0}:{1} -> {2}", src.ClientAddress, src.TargetDx, src.TargetAddress);

        const string RexFieldPattern = "[W:{0} | R:{1} | X:{2} | B:{3}]";
    }
}