//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmRender
    {
        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> lines(in AsmRoutine src, in AsmFormatConfig config)
        {
            var summaries = asm.summarize(src);
            var count = summaries.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            for(var i=0u; i< count; i++)
                seek(dst,i)= format(src.BaseAddress, skip(summaries,i), config);
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static string format(AsmSpecifier src, byte[] encoded, string sep)
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHexBytes(Space,true,false));

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
            dst.Append(text.concat(asm.label(label, out _), src.Formatted.PadRight(config.InstructionPad, Space)));
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
                foreach(var line in asm.header(src))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {

            if(config.EmitFunctionHeader)
                foreach(var line in asm.header(src))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }
    }
}