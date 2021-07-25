//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Chars;
    using static core;

    [ApiHost]
    public readonly struct AsmRender
    {
        const char Open = Chars.LBracket;

        const string Sep = " | ";

        const char Close = Chars.RBracket;

        const string To = " => ";

        [Op]
        public static string delimited(Register src)
        {
            const string Sep = " | ";
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndexCode,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClassCode,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidthCode,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        public static string format(in AsmHostStatement src)
            => string.Format("{0} {1,-36} ; {2} => {3}",
                        src.BlockOffset,
                        src.Expression,
                        string.Format("({0})<{1}>[{2}] => {3}", src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format()),
                        AsmBitstrings.format(src.Encoded)
                        );

        public static string format(AsmBlockLabel src)
        {
            return src.Name.IsEmpty ? EmptyString : string.Format("{0}:", src.Name);
        }

        [Op]
        public static string format(AsmOffsetLabel src)
        {
            const string LabelPattern = "{0}h ";
            var width = src.OffsetWidth;
            var value = src.OffsetValue;
            var f = EmptyString;
            // if(width <= 8)
            //     f = HexFormat.format(w8,(byte)value);
            if(width <= 16)
                f = HexFormat.format(w16,(ushort)value);
            else if(width <= 32)
                f = HexFormat.format(w32,(uint)value);
            else
                f = HexFormat.format(w64,(ulong)value);

            return string.Format(LabelPattern, f);
        }

        public static string format(in AsmDisassembly src)
        {
            var left = string.Format("{0,-12} {1,-64}", src.Offset, src.Statement);
            var right = asm.comment(string.Format("{0,-32} {1}", src.Code, src.Bitstring));
            return string.Format("{0}{1}", left, right);
        }

        public static string format<T>(in RegExpr<T> src)
            where T : unmanaged, IRegOp
        {
            var dst = CharBlock32.Null.Data;
            var i=0u;
            var count = render(src, ref i, dst);
            return text.format(dst, count);
        }

        public static uint render<T>(in RegExpr<T> src, ref uint i, Span<char> dst)
            where T : unmanaged, IRegOp
        {
            var i0 = i;
            var @base = src.Base.Format();
            var index = src.Index.Format();
            copy(@base, ref i, dst);
            var scale = src.Scale.Format();
            if(src.Scale.IsNonZero)
            {
                seek(dst,i++) = Chars.Plus;
                copy(index, ref i, dst);
                if(src.Scale.IsNonUnital)
                {
                    seek(dst,i++) = Chars.Star;
                    copy(scale,ref i, dst);
                }
            }

            if(src.Dx != 0)
            {
                seek(dst,i++) = Chars.Plus;
                copy(src.Dx.ToString("x") + "h", ref i, dst);
            }

            return i - i0;
        }

        public static string format(in AsmSig src)
        {
            var dst = TextTools.buffer();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static uint render(in AsmDisassembly src, Span<char> dst)
        {
            var i=0u;
            Hex.render(LowerCase,src.Offset, ref i, dst);
            seek(dst,i++) = Chars.Space;
            text.copy(src.Statement.Data, ref i, dst);
            return i;
        }

        public static string format(in AsmDisassembly src, Span<char> buffer)
        {
            var count = render(src,buffer);
            return text.format(slice(buffer,0,count));
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
            => text.format(BitRender.render(n8, n4, src.Encoded));

        [Op]
        public static string bitfield(RexPrefix src)
            => string.Format(RexFieldPattern, src.W(), src.R(), src.X(), src.B());

        [Op]
        public static uint bits(Vsib src, Span<char> dst)
        {
            var i=0u;
            seek(dst,i++) = Open;
            BitNumbers.render(src.SS(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Index(), ref i, dst);
            seek(dst,i++) = Chars.Space;
            BitNumbers.render(src.Base(), ref i, dst);
            seek(dst,i++) = Close;
            return i;
        }

        public static uint RexTable(ITextBuffer dst)
        {
            var bits = RexPrefix.Range();
            var count = bits.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(describe(skip(bits,i)));
            return (uint)count;
        }

        public static string describe(RexPrefix src)
        {
            var bits = text.format(BitRender.render(n8, n4, src.Encoded));
            var bitfield = string.Format(RexFieldPattern, src.W(), src.R(), src.X(), src.B());
            return $"{src.Encoded.FormatAsmHex()} | [{bits}] => {bitfield}";
        }

        public static uint modRmBits(Span<char> dst)
        {
            var f0 = BitSeq.bits(n3);
            var f1 = BitSeq.bits(n3);
            var f2 = BitSeq.bits(n2);
            var k=0u;
            for(var c=0u; c<f2.Length; c++)
            for(var b=0u; b<f1.Length; b++)
            for(var a=0u; a<f0.Length; a++)
            {
                var modrm = AsmEncoder.modrm(skip(f0, a), skip(f1, b), skip(f2, c));
                bitfield(modrm, ref k, dst);
                seek(dst, k++) = Chars.Space;
                seek(dst, k++) = Chars.Eq;
                seek(dst, k++) = Chars.Space;

                var bits = modrm.Encoded.FormatBits() + "b";
                text.copy(bits, ref k, dst);

                seek(dst, k++) = Chars.Space;
                seek(dst, k++) = Chars.Eq;
                seek(dst, k++) = Chars.Space;

                var hex = modrm.Encoded.FormatAsmHex(2);
                text.copy(hex, ref k, dst);

                seek(dst,k++) = (char)AsciControl.CR;
                seek(dst,k++) = (char)AsciControl.LF;
            }
            return k;
        }

        public static uint bitfield(ModRmByte src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            const string ModRM = "ModRM";
            const string Mod = "mod";
            const string Reg = "reg";
            const string Rm = "r/m";
            copy(ModRM, ref i, dst);
            seek(dst, i++) = Open;

            copy(Mod, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n2, src.Mod(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;

            copy(Reg, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n3, src.Reg(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;

            copy(Rm, ref i, dst);
            seek(dst, i++) = Open;
            BitRender.render(n3, src.Rm(), ref i, dst);
            seek(dst, i++) = Close;

            seek(dst, i++) = Close;
            return i - i0;
        }

        static void copy(ReadOnlySpan<char> src,ref uint i, Span<char> dst)
            => text.copy(src, ref i, dst);

        [Op]
        public static string rescomment(OpUri uri, BinaryCode src)
            => string.Format("; {0}", SpanRes.format(SpanRes.specify(uri, src)));

        [Op]
        public static byte format(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = asm.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = rescomment(src.Uri, src.CodeBlock);
            seek(dst, i++) = asm.comment(string.Concat(nameof(src.CodeBlock.BaseAddress), RP.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = asm.comment(string.Concat(nameof(src.TermCode), RP.spaced(Chars.Eq), src.TermCode.ToString()));
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
        public static string format(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config)
        {
            var dst = TextTools.buffer();
            render(@base, src, config, dst);
            return dst.ToString();
        }

        [Op]
        public static void render(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config, ITextBuffer dst)
        {
            const string AbsolutePattern = "{0} {1} {2}";
            const string RelativePattern = "{0} {1}";

            var label = AsmRender.offset(src.Offset, w16);
            var address = @base + src.Offset;
            if(config.AbsoluteLabels)
                dst.Append(string.Format(AbsolutePattern, address.Format(), label, src.Statement.FormatPadded()));
            else
                dst.Append(string.Format(RelativePattern, label, src.Statement.FormatPadded()));

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
            const byte ExprWidth = 46;
            const sbyte ExprPad = -ExprWidth;

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
        public static string format(AsmMnemonic monic, ReadOnlySpan<AsmSigOpExpr> operands)
        {
            var dst = text.buffer();
            render(monic, operands, dst);
            return dst.Emit();
        }

        [Op]
        public static void render(AsmMnemonic monic, ReadOnlySpan<AsmSigOpExpr> operands, ITextBuffer dst)
        {
            dst.Append(monic.Format(MnemonicCase.Uppercase));
            var opcount = operands.Length;
            if(opcount != 0)
            {
                dst.Append(Chars.Space);
                dst.Append(operands.Delimit(Chars.Comma).Format());
            }
        }

        [Op]
        public static string format(SibByte src)
        {
            var dst = TextTools.buffer();
            dst.Append(src.Base().Format());
            dst.Append(Chars.Space);
            dst.Append(src.Index().Format());
            dst.Append(Chars.Space);
            dst.Append(src.Scale().Format());
            return dst.ToString();
        }

        [Op]
        public static string format(in AsmBranchInfo src)
            => string.Concat(src.Source, " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

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

        [Op]
        public static string semantic(in AsmDetailRow row)
        {
            var monic = AsmMnemonicCode.None;
            if(!AsmParser.parse(row.Mnemonic, out monic))
                return string.Format("The mnemonic {0} is not known", row.Mnemonic);

            var encoded = row.Encoded;
            var ip = row.IP;
            var @base = row.BlockAddress;

            switch(monic)
            {
                case AsmMnemonicCode.JMP:

                if(JmpRel8.test(encoded))
                    return string.Format("jmp(rel8,{0},{1}) -> {2}",
                        JmpRel8.dx(encoded),
                        JmpRel8.offset(@base, ip, encoded),
                        JmpRel8.target(ip, encoded)
                        );
                else if(JmpRel32.test(encoded))
                    return string.Format("jmp(rel32,{0},{1}) -> {2}",
                        JmpRel32.dx(encoded).FormatMinimal(),
                        JmpRel32.offset(@base, ip, encoded).FormatMinimal(),
                        JmpRel32.target(ip, encoded)
                        );
                else if(Jmp64.test(encoded))
                    return string.Format("jmp({0})", Jmp64.target(encoded));

                break;
            }
            return EmptyString;
        }

        public static void bitfields(ReadOnlySpan<CpuIdRow> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                bitfield(skip(src,i), dst);
        }

        public static void bitfield(in CpuIdRow row, ITextBuffer dst)
        {
            var w = n8;
            dst.AppendFormat("eax (in): {0} [{1}] | ", row.Leaf, row.Leaf.FormatBitstring(w));
            dst.AppendFormat("ecx (in): {0} [{1}] | ", row.Subleaf, row.Subleaf.FormatBitstring(w));
            dst.Append(" => ");
            dst.AppendFormat("eax (out): {0} [{1}] | ", row.Eax, row.Eax.FormatBitstring(w));
            dst.AppendFormat("ebx (out): {0} [{1}] | ", row.Ebx, row.Ebx.FormatBitstring(w));
            dst.AppendFormat("ecx (out): {0} [{1}] | ", row.Ecx, row.Ecx.FormatBitstring(w));
            dst.AppendFormat("edx (out): {0} [{1}] ", row.Edx, row.Edx.FormatBitstring(w));
            dst.AppendLine();
        }

        const string RexFieldPattern = "[W:{0} | R:{1} | X:{2} | B:{3}]";
    }
}