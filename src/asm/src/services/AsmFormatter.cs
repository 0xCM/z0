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

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public AsmRoutineFormat Format(AsmRoutine src)
            => format(src, _Config);

        public AsmFormatConfig Config
        {
            [MethodImpl(Inline)]
            get => _Config;
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
        public static AsmRoutineFormat format(AsmRoutine src, in AsmFormatConfig config)
        {
            var dst = text.buffer();
            render(src, config, dst);
            return new AsmRoutineFormat(dst.Emit());
        }

        [Op]
        public static string format(MemoryAddress @base, in AsmInstructionInfo src, in AsmFormatConfig config)
        {
            var dst = text.buffer();
            AsmRender.render(@base, src, config, dst);
            return dst.ToString();
        }

        [Op]
        public static void render(AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {
            const string Separator = "; " + RP.PageBreak160;
            var buffer = span<string>(8);
            var count = AsmRender.format(src.AsmHeader(), buffer);
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(buffer,i));
            dst.AppendLine(instructions(src, config).Join(Eol));
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
    }
}