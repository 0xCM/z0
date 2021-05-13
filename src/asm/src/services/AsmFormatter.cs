//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class AsmFormatter : AppService<AsmFormatter>,  IAsmRoutineFormatter
    {
        AsmFormatConfig _Config;

        Index<string> HeaderBuffer;

        public AsmFormatter()
        {
            AsmFormatConfig.@default(out _Config);
            HeaderBuffer = alloc<string>(16);
        }

        public AsmFormatConfig Config
        {
            [MethodImpl(Inline)]
            get => _Config;
        }

        [Op]
        public static void format(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config, ITextBuffer dst)
        {
            const string AbsolutePattern = "{0} {1} {2}";
            const string RelativePattern = "{0} {1}";

            var label = asm.label(w16, src.Offset);
            var address = @base + src.Offset;

            if(config.AbsoluteLabels)
                dst.Append(string.Format(AbsolutePattern, address.Format(), label.Format(), src.Statement.FormatFixed()));
            else
                dst.Append(string.Format(RelativePattern, label.Format(), src.Statement.FormatFixed()));

            dst.Append(AsmCore.comment(AsmRender.format(src.AsmForm, src.Encoded, config.FieldDelimiter)));
        }

        public static void render(ReadOnlySpan<byte> block, ReadOnlySpan<IceInstruction> instructions, ITextBuffer dst)
        {
            Address16 offset = z16;
            var count = instructions.Length;
            dst.AppendLine(AsmCore.comment(block.FormatHex()));
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var size = instruction.InstructionSize;
                var code = slice(block, offset, size);
                dst.AppendLineFormat("{0,-6} {1,-46} ; {2,-2} | {3}", offset, instruction.FormattedInstruction, size, code.FormatHex());
                offset += size;
            }
        }

        [Op]
        public static byte AsmHeader(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = AsmCore.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.asmcomment(src.Uri, src.CodeBlock);
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            seek(dst, i++) = src.Separator;
            return i;
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<string> AsmHeaderLines(AsmRoutine src)
        {
            var dst = span<string>(8);
            const string Separator = "; " + RP.PageBreak160;
            var count = AsmHeader(new ApiCodeBlockHeader(Separator, src.Code.OpUri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static void RenderHeader(AsmRoutine src, ITextBuffer dst)
        {
            const string Separator = "; " + RP.PageBreak160;
            var buffer = span<string>(8);
            var count = AsmHeader(new ApiCodeBlockHeader(Separator, src.Code.OpUri, src.DisplaySig, src.Code, src.TermCode), buffer);
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(buffer,i));
        }

        [Op]
        public static AsmRoutineFormat format(AsmRoutine src, in AsmFormatConfig config)
        {
            var dst = text.buffer();
            format(src, config, dst);
            return (src, dst.Emit());
        }

        [Op]
        public static string format(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config)
        {
            var dst = text.buffer();
            AsmFormatter.format(@base, src, config, dst);
            return dst.ToString();
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public AsmRoutineFormat Format(AsmRoutine src)
            => format(src, _Config);

        public string Format(AsmInstructionBlock src)
        {
            var dst = text.buffer();
            render(src.Code.Encoded, src.Instructions, dst);
            return dst.Emit();
        }

        public string Format(in MemoryAddress @base, in AsmInstructionInfo src)
            => format(@base, src, _Config);

        public void Render(AsmRoutine src, ITextBuffer dst)
            => format(src, _Config, dst);

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public ReadOnlySpan<string> HeaderLines(AsmRoutine src)
        {
            var dst = HeaderBuffer.Edit;
            const string Separator = "; " + RP.PageBreak160;
            var count = AsmHeader(new ApiCodeBlockHeader(Separator, src.Code.OpUri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }

        public ReadOnlySpan<string> HeaderLines(in ApiCodeBlock code, in MethodDisplaySig sig)
        {
            var dst = HeaderBuffer.Edit;
            const string Separator = "; " + RP.PageBreak160;
            var count = AsmHeader(new ApiCodeBlockHeader(Separator, code.OpUri, sig, code, default), dst);
            return slice(dst, 0, count);
        }


        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> instructions(AsmRoutine src, in AsmFormatConfig config)
        {
            var summaries = AsmRoutines.summarize(src);
            var count = summaries.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            for(var i=0u; i< count; i++)
                seek(dst,i)= format(src.BaseAddress, skip(summaries,i), config);
            return dst;
        }

        [Op]
        public static void format(AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {
            //root.iter(header(src), line => dst.Append(line));
            RenderHeader(src, dst);
            dst.AppendLine(instructions(src, config).Join(Eol));
        }
    }
}