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
    using static AsmRenderPatterns;

    [ApiHost]
    public readonly struct AsmRender
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static uint bitstring(in AsmHexCode src, Span<char> dst)
        {
            var i=0u;
            return BitRender.render8x4(slice(src.Bytes, 0, src.Size), ref i, dst);
        }

        [Op]
        public static uint bitstring(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var i=0u;
            return BitRender.render8x4(src, ref i, dst);
        }

        [Op]
        public static ReadOnlySpan<char> bitstring(in AsmHexCode src)
        {
            if(src.IsEmpty)
                return default;

            CharBlocks.alloc(n256, out var block);
            var dst = block.Data;
            var count = bitstring(src, dst);
            if(count == 0)
                return EmptyString;

            return slice(dst, 0, count);
        }

        [MethodImpl(Inline), Op]
        public static uint render8x3x3x2(in AsmHexCode src, ref uint i, Span<char> dst)
            => BitRender.render8x3x3x2(slice(src.Bytes, src.Size), ref i, dst);

        [Op,Closures(Closure)]
        public static ReadOnlySpan<char> bitstring<T>(in AsmRegValue<T> src, char sep = Chars.Space)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return BitRender.render8(u8(src.Value));
            else if(size<T>() == 2)
                return BitRender.render16x8(u16(src.Value), sep);
            else if(size<T>() == 4)
                return BitRender.render32x8(u32(src.Value));
            else if(size<T>() == 8)
                return BitRender.render64x8(u64(src.Value));
            else
                return EmptyString;
        }

        [Op]
        public static string format8x4(AsmHexCode src)
            => src.IsEmpty ? EmptyString : text.format(bitstring(src));

        [MethodImpl(Inline), Op]
        public static uint render8x4(in AsmHexCode src, ref uint i, Span<char> dst)
            => BitRender.render8x4(slice(src.Bytes, 0, src.Size), ref i, dst);

        public static string format(in RegRange src)
            => string.Format("{0}[{1}..{2}]", src.Class, src.MinIndex, src.MaxIndex);

        public static string format(in Disp32Link src)
            => string.Format("{0}h:{1} -> {2}", src.Disp, src.Source, src.Target);

        public static string format(in HostAsmRecord src)
            => string.Format("{0} {1,-36} # {2} => {3}",
                        src.BlockOffset,
                        src.Expression,
                        string.Format("({0})<{1}>[{2}] => {3}", src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format()),
                        format8x4(src.Encoded)
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
                f = HexFormatter.format(w16,(ushort)value);
            else if(width <= 32)
                f = HexFormatter.format(w32,(uint)value);
            else
                f = HexFormatter.format(w64,(ulong)value);

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

        const AsmCommentMarker CommentMarker = AsmCommentMarker.Hash;

        const string PageBreak = "#" + CharText.Space + RP.PageBreak160;

        [Op]
        public static AsmInlineComment spanres(OpUri uri, BinaryCode src)
            => asm.comment(CommentMarker, SpanRes.format(SpanRes.specify(uri, src)));

        [Op]
        public static AsmInlineComment hexarray(BinaryCode src)
            => asm.comment(CommentMarker, Hex.hexarray(src).Format(true));

        [Op]
        public static byte format(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = PageBreak;
            seek(dst, i++) = asm.comment(CommentMarker, $"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = spanres(src.Uri, src.CodeBlock);
            seek(dst, i++) = hexarray(src.CodeBlock);
            seek(dst, i++) = asm.comment(CommentMarker, string.Concat(nameof(src.CodeBlock.BaseAddress), RP.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = asm.comment(CommentMarker, string.Concat(nameof(src.TermCode), RP.spaced(Chars.Eq), src.TermCode.ToString()));
            seek(dst, i++) = PageBreak;
            seek(dst, i++) = format(asm.label(src.Uri.OpId.Name));
            return i;
        }

        public static string format(in AsmLabel src)
            => string.Format("{0}:", src.Name);

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
            var _label = asm.label(16, src.Offset);
            var address = @base + src.Offset;
            if(config.EmitLineLabels)
            {
                if(config.AbsoluteLabels)
                    dst.Append(string.Format(AbsolutePattern, address.Format(), label, src.Statement.FormatPadded()));
                else
                    dst.Append(string.Format(RelativePattern, label, src.Statement.FormatPadded()));
            }
            else
            {
                dst.Append(src.Statement.FormatPadded());
            }

            dst.Append(asm.comment(CommentMarker, format(_label, src.AsmForm, src.Encoded)));
        }

        public static string comment(in AsmThumbprint src)
            => asm.comment(CommentMarker, string.Format("({0})<{1}>[{2}] => {3}", src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format()));

        [Op]
        public static string format(in AsmThumbprint src)
            => string.Format("{0} {1}", src.Statement.FormatPadded(), comment(src));

        [Op]
        public static string format(in AsmOffsetLabel label, in AsmFormExpr src, byte[] encoded)
            => string.Format(InstInfoPattern,
                label,
                encoded.Length,
                encoded.FormatHex(),
                src.Sig,
                src.OpCode
                );

        [Op]
        public static string bitstring(in AsmThumbprint src)
            => string.Format("{0} => {1}", format(src), format8x4(src.Encoded));

        [Op]
        public static string thumbprint(in AsmEncodingInfo src)
        {
            var bits = format8x4(src.Encoded);
            var statement = string.Format("{0} # ({1})<{2}>[{3}] => {4}", src.Statement.FormatPadded(), src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format());
            return string.Format("{0} => {1}", statement, format8x4(src.Encoded));
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

        public static string regop<T>(T src)
            where T : unmanaged, IRegOp<T>
        {
            var op = AsmRegs.reg(src.WidthCode, src.RegClassCode, src.Index);
            return op.Name.Format();
        }

        [Op]
        public static string format(RegWidth src)
        {
            var symbols = Symbols.index<NativeSizeCode>();
            var index = (byte)src.Size.Code;
            var symbol = symbols[index];
            return symbol.Expr.Format();
        }

        [Op]
        public static string format(RegClass src)
        {
            var symbols = Symbols.index<RegClassCode>();
            var index = (byte)src.Code;
            var symbol = symbols[index];
            return symbol.Expr.Format();
        }

        public static void regvals(ReadOnlySpan<CpuIdRow> src, ITextBuffer dst)
        {
            const sbyte ColWidth = 46;
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
            dst.AppendFormat("{0} [{1}] | ", row.Leaf, row.Leaf.FormatBits(w));
            // ecx(in)
            dst.AppendFormat("{0} [{1}] | ", row.Subleaf, row.Subleaf.FormatBits(w));
            // eax(out)
            dst.AppendFormat("{0} [{1}] | ", row.Eax, row.Eax.FormatBits(w));
            // ebx(out)
            dst.AppendFormat("{0} [{1}] | ", row.Ebx, row.Ebx.FormatBits(w));
            // ecx(out)
            dst.AppendFormat("{0} [{1}] | ", row.Ecx, row.Ecx.FormatBits(w));
            // edx(out)
            dst.AppendFormat("{0} [{1}] ", row.Edx, row.Edx.FormatBits(w));
            dst.AppendLine();
        }
    }
}