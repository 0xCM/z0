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

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string Format(AsmRoutine src)
            => format(src, _Config);

        public string Format(in MemoryAddress @base, in AsmInstructionSummary src)
            => format(@base, src, _Config);

        public void Render(in AsmRoutine src, ITextBuffer dst)
            => format(src, _Config, dst);

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public ReadOnlySpan<string> FormatHeader(AsmRoutine src)
        {
            //var dst = span<string>(8);
            var dst = HeaderBuffer.Edit;
            const string Separator = "; " + RP.PageBreak160;
            var count = lines(new ApiCodeBlockHeader(Separator, src.Code.OpUri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }

        public static void render(ReadOnlySpan<byte> block, ReadOnlySpan<IceInstruction> src, ITextBuffer dst)
        {
            Address16 offset = z16;
            var count = src.Length;
            dst.AppendLine(AsmCore.comment(block.FormatHex()));
            for(var i=0; i<count; i++)
            {
                ref readonly var fx = ref skip(src,i);
                var size = (byte)fx.ByteLength;
                var code = slice(block,offset,size);
                dst.AppendLineFormat("{0,-6} {1,-46} ; {2,-2} | {3}", offset, fx.FormattedInstruction, size, code.FormatHex());
                offset += size;
            }
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
            var count = lines(new ApiCodeBlockHeader(Separator, src.Code.OpUri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }

        [Op]
        static byte lines(in ApiCodeBlockHeader src, Span<string> dst)
        {
            var i = z8;
            seek(dst, i++) = src.Separator;
            seek(dst, i++) = AsmCore.comment($"{src.DisplaySig}::{src.Uri}");
            seek(dst, i++) = ByteSpans.property(src.CodeBlock, src.Uri.OpId);
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            seek(dst, i++) = AsmCore.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            return i;
        }

        [Op]
        public static string format(AsmFormExpr src, byte[] encoded, string sep)
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHex());

        [Op]
        public static void format(MemoryAddress @base, in AsmInstructionSummary src, in AsmFormatConfig config, StringBuilder dst)
        {
            const string AbsolutePattern = "{0} {1} {2}";
            const string RelativePattern = "{0} {1}";

            var label = asm.label(w16, src.Offset);
            var address = @base + src.Offset;

            if(config.AbsoluteLabels)
                dst.Append(string.Format(AbsolutePattern, address.Format(), label.Format(), src.Statement.FormatFixed()));
            else
                dst.Append(string.Format(RelativePattern, label.Format(), src.Statement.FormatFixed()));

            dst.Append(AsmCore.comment(format(src.AsmForm, src.Encoded, config.FieldDelimiter)));
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

                seek(dst, i) = IceExtractors.summarize(@base, instruction.Instruction, src.Code.Code, instruction.Statment, offset);
                offset += size;
            }
            return dst;
        }

        [Op]
        public static string format(MemoryAddress @base, in AsmInstructionSummary src, in AsmFormatConfig config)
        {
            var dst = text.build();
            AsmFormatter.format(@base, src, config, dst);
            return dst.ToString();
        }

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> instructions(in AsmRoutine src, in AsmFormatConfig config)
        {
            var summaries = AsmFormatter.summarize(src);
            var count = summaries.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            for(var i=0u; i< count; i++)
                seek(dst,i)= format(src.BaseAddress, skip(summaries,i), config);
            return dst;
        }

        [Op]
        public static string format(in AsmRoutine src, in AsmFormatConfig config)
        {
            var dst = text.build();
            format(src, config, dst);
            return dst.ToString();
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, StringBuilder dst)
        {
            foreach(var line in AsmFormatter.header(src))
                dst.AppendLine(line);

            dst.AppendLine(AsmFormatter.instructions(src, config).Join(Eol));
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {
            foreach(var line in AsmFormatter.header(src))
                dst.AppendLine(line);

            dst.AppendLine(AsmFormatter.instructions(src, config).Join(Eol));
        }
    }
}