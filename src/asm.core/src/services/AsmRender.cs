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

        const char Close = Chars.RBracket;

        const string To = " => ";

        public static string format(in AsmHostStatement src)
            => string.Format("{0} {1,-36} ; {2} => {3}",
                        src.BlockOffset,
                        src.Expression,
                        string.Format("({0})<{1}>[{2}] => {3}", src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format()),
                        AsmBitstrings.format(src.Encoded)
                        );

        public static string format(AsmBlockLabel src)
            => src.Name.IsEmpty ? EmptyString : string.Format("{0}:", src.Name);

        [Op]
        public static string format(AsmOffsetLabel src)
        {
            const string LabelPattern = "{0}h ";
            var width = src.OffsetWidth;
            var value = src.OffsetValue;
            var f = EmptyString;
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

        public static string format(in AsmAddress src)
        {
            var dst = CharBlock32.Null.Data;
            var i=0u;
            var count = render(src, ref i, dst);
            return text.format(dst, count);
        }

        public static uint render(in AsmAddress src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var @base = src.Base.Format();
            var index = src.Index.Format();
            text.copy(@base, ref i, dst);
            var scale = src.Scale.Format();
            if(src.Scale.IsNonZero)
            {
                seek(dst,i++) = Chars.Plus;
                text.copy(index, ref i, dst);
                if(src.Scale.IsNonUnital)
                {
                    seek(dst,i++) = Chars.Star;
                    text.copy(scale,ref i, dst);
                }
            }

            if(src.Disp.Value != 0)
            {
                seek(dst,i++) = Chars.Plus;
                text.copy(src.Disp.Value.ToString("x") + "h", ref i, dst);
            }

            return i - i0;
        }

        [Op]
        public static uint render(in AsmDisassembly src, Span<char> dst)
        {
            var i=0u;
            Hex.render(LowerCase,(Hex64)src.Offset, ref i, dst);
            seek(dst,i++) = Chars.Space;
            text.copy(src.Statement.Data, ref i, dst);
            return i;
        }

        public static string format(in AsmDisassembly src, Span<char> buffer)
        {
            var count = render(src,buffer);
            return text.format(slice(buffer,0,count));
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

        [MethodImpl(Inline), Op]
        public static uint hexbytes(Hex64 src, Span<char> dst)
        {
            var i=0u;
            var data = bytes(src);
            var count = data.Length;
            for(var j=0; j<count; j++)
            {
                ref readonly var b = ref skip(data, j);
                Hex.render(LowerCase, (Hex8)b, ref i, dst);
                if(j != count - 1)
                    seek(dst, i++) = Chars.Space;
            }
            return i;
        }

        [MethodImpl(Inline), Op]
        public static CharBlock24 hexbytes(Hex64 src)
        {
            var dst = CharBlock24.Null;
            hexbytes(src, dst.Data);
            return dst;
        }

        [Op]
        public static string bits(RexPrefix src)
            => text.format(BitRender.render4x4(src.Encoded));

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
            var bits = text.format(BitRender.render4x4(src.Encoded));
            var bitfield = string.Format(RexFieldPattern, src.W(), src.R(), src.X(), src.B());
            return $"{src.Encoded.FormatAsmHex()} | [{bits}] => {bitfield}";
        }

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
            var dst = text.buffer();
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

                counter += AsmBitstrings.render8x4(n8, n4, src.Encoded, counter, dst);
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

        public static void regvals(ReadOnlySpan<CpuIdRow> src, ITextBuffer dst)
        {
            const sbyte ColWidth = 47;
            const byte ColCount = 6;
            var slots = array(RP.pad(0,-ColWidth), RP.pad(1,-ColWidth), RP.pad(2,-ColWidth), RP.pad(3,-ColWidth), RP.pad(4,-ColWidth), RP.pad(5,-ColWidth));
            var pattern = string.Format("{0} | {1} | {2} | {3} | {4} | {5}", slots);
            var header = string.Format(pattern, "eax(in)", "ecx(in)", "eax(out)", "ebx(out)", "ecx(out)", "edx(out)");
            dst.AppendLine(header);
            var count = src.Length;
            for(var i=0; i<count; i++)
                regvals(skip(src,i), dst);
        }

        public static void regvals(in CpuIdRow row, ITextBuffer dst)
        {
            var w = n8;
            // eax(in)
            dst.AppendFormat("{0} [{1}] | ", row.Leaf, row.Leaf.FormatBitstring(w));
            // ecx(in)
            dst.AppendFormat("{0} [{1}] | ", row.Subleaf, row.Subleaf.FormatBitstring(w));
            // eax(out)
            dst.AppendFormat("{0} [{1}] | ", row.Eax, row.Eax.FormatBitstring(w));
            // ebx(out)
            dst.AppendFormat("{0} [{1}] | ", row.Ebx, row.Ebx.FormatBitstring(w));
            // ecx(out)
            dst.AppendFormat("{0} [{1}] | ", row.Ecx, row.Ecx.FormatBitstring(w));
            // edx(out)
            dst.AppendFormat("{0} [{1}] ", row.Edx, row.Edx.FormatBitstring(w));
            dst.AppendLine();
        }

        const string RexFieldPattern = "[W:{0} | R:{1} | X:{2} | B:{3}]";
    }
}