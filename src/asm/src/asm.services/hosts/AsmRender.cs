//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static memory;
    using static AsmDocParts;

    [ApiHost]
    public readonly struct AsmRender
    {
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallTarget src)
            => text.concat(src.Base.Format(), Chars.Colon, Chars.Space, text.ifempty(src.Id, "target"));

        /// <summary>
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallInfo src)
        {
            var site = src.InstructionAddress;
            var target =  src.CalledTarget.Base;
            var o = (site - target).Location;
            var delta = (src.ActualTarget.Base - site).Location;
            var actual = src.ActualTarget.Id;
            var client_field = text.concat(src.Client.Id, text.embrace(site.Format()));
            return $"{client_field} | {target} | {o} | {actual} | {delta}";
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<string> header(AsmRoutine src)
        {
            var dst = span<string>(8);
            const string Separator = "; " + RP.PageBreak160;
            var count = lines(new BlockHeader(Separator, src.Code.Uri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }

        [Op]
        public static byte lines(in BlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = asm.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.property(src.CodeBlock, src.Uri.OpId);
            seek(dst, i++) = asm.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = asm.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            return i;
        }

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> lines(in AsmRoutine src, in AsmFormatConfig config)
        {
            var summaries = summarize(src);
            var count = summaries.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            for(var i=0u; i< count; i++)
                seek(dst,i)= format(src.BaseAddress, skip(summaries,i), config);
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<AsmInstructionSummary> summarize(in AsmRoutine src)
        {
            var count = src.InstructionCount;
            var buffer = new AsmInstructionSummary[count];
            var offset = 0u;
            var @base = src.BaseAddress;
            var view = src.Instructions.View;
            var dst = span(buffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var size = (uint)instruction.ByteLength;

                if(src.Code.Length < offset + size)
                {
                    term.error($"Instruction size mismatch {instruction.IP} {offset} {src.Code.Length} {size}");
                    continue;
                }

                seek(dst, i) = IceExtractors.summarize(@base, instruction, src.Code.Code, instruction.FormattedInstruction, offset);
                offset += size;
            }
            return dst;
        }

        [Op]
        public static string format(in LineLabel src, out string dst)
            => dst = src.Width switch{
                DataWidth.W8 => ScalarCast.uint8(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W16 => ScalarCast.uint16(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W32 => ScalarCast.uint32(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W64 => src.Offset.FormatAsmHex() + CharText.Space,
                _ => EmptyString
            };


        [MethodImpl(Inline), Op]
        public static string format(AsmInstructionSpecExprLegacy src, byte[] encoded, string sep)
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHex());

        [Op]
        public static string format(in MemoryAddress @base, in AsmInstructionSummary src, in AsmFormatConfig config)
        {
            var dst = text.build();
            format(@base, src, config, dst);
            return dst.ToString();
        }

        [Op]
        public static void format(in MemoryAddress @base, in AsmInstructionSummary src, in AsmFormatConfig config, StringBuilder dst)
        {
            var label = asm.label(w16, src.Offset);
            var absolute = @base + src.Offset;
            dst.Append(text.concat(format(label, out _), src.Formatted.PadRight(config.InstructionPad, Space)));
            dst.Append(asm.comment(format(src.Spec, src.Encoded, config.FieldDelimiter)));
        }

        [Op]
        public static void format(in AsmRoutines src, in AsmFormatConfig config, ITextBuffer dst)
        {
            var count = src.Count;
            if(count != 0)
            {
                ref var x = ref src.First;
                for(var i=0; i<count; i++)
                {
                    var l = lines(skip(x,i), config);
                    dst.Append(l.Concat(Eol));
                    dst.AppendLine();
                }
            }
        }

        [Op]
        public static string format(in AsmRoutine src, in AsmFormatConfig config)
        {
            var dst = text.build();
            format(src,config, dst);
            return dst.ToString();
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, StringBuilder dst)
        {
            if(config.EmitFunctionHeader)
                foreach(var line in header(src))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {

            if(config.EmitFunctionHeader)
                foreach(var line in header(src))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }
    }
}