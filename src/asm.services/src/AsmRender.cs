//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct AsmRender
    {
        const char Space = Chars.Space;

        /// <summary>
        /// Formats source bits on a single line intended for emission in the function header
        /// </summary>
        /// <param name="src">The source bits</param>

        [MethodImpl(Inline), Op]
        public static string header(BasedCodeBlock src, OpIdentity id)
            => comment(new ByteSpanProperty(id.ToPropertyName(), src).Format());

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<string> header(AsmRoutine src, in AsmFormatConfig config)
        {
            var lines = new List<string>();
            lines.Add(comment($"{src.OpSig}, {src.Uri}"));

            if(config.EmitFunctionHeaderEncoding)
                lines.Add(header(src.Code.Code, src.OpId));
            else
                lines.Add(comment(src.Code.Uri.OpId));

            if(config.EmitBaseAddress)
                lines.Add(comment(text.concat("Base", text.spaced(Chars.Eq), src.Code.Base)));

            if(config.EmitCaptureTermCode)
            {
                var cidesc = string.Empty;
                if(config.EmitCaptureTermCode)
                    cidesc += text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString());

                lines.Add(comment(cidesc));
            }

            if(config.EmitFunctionTimestamp)
                lines.Add(comment(Time.now().ToLexicalString()));

            return lines.ToArray();
        }

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

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> lines(in AsmFxList src, in AsmFormatConfig config)
        {
            var count = src.Count;
            if(count == 0)
                return default;

            //var config = cfg ?? AsmFormatSpec.Default;
            var summaries =  asm.summarize(src);
            var lines = span<string>(count);
            var @base = src[0].IP;

            for(var i=0u; i<(uint)count; i++)
                seek(lines,i) = format(@base, skip(summaries,i), config);
            return lines;
        }

        [MethodImpl(Inline), Op]
        public static string comment(string text)
            =>  $"; {text}";

        [MethodImpl(Inline), Op]
        public static string format(AsmSpecifier src, byte[] encoded, string sep)
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Instruction, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHexBytes(Space,true,false));

        /// <summary>
        /// Formats a line label
        /// </summary>
        /// <param name="src">The relative line location</param>
        [MethodImpl(Inline), Op]
        public static string label(ushort src)
            => text.concat(src.FormatSmallHex(), HexFormatSpecs.PostSpec, Space);

        [MethodImpl(Inline), Op]
        public static string label(ulong src)
            => text.concat(src.FormatAsmHex(), Space);

        [Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src, in AsmFormatConfig config)
        {
            var description = text.build();
            var absolute = @base + src.Offset;
            var ll = label((ushort)src.Offset);
            description.Append(text.concat(ll, src.Formatted.PadRight(config.InstructionPad, Space)));
            description.Append(comment(format(src.Spec, src.Encoded, config.FieldDelimiter)));
            return description.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src)
            => format(@base, src, AsmFormatConfig.Default);

        [Op]
        public static string format(in AsmRoutines src, in AsmFormatConfig config)
        {
            var dst = text.build();
            for(var i=0; i<src.Data.Length; i++)
            {
                dst.Append(lines(src.Data[i], config).Concat());
                dst.AppendLine(text.PageBreak);
            }
            return dst.ToString();
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        [Op]
        public static string format(in AsmRoutine src, in AsmFormatConfig config)
        {
            var dst = text.build();

            if(config.EmitSectionDelimiter)
                dst.AppendLine(config.SectionDelimiter);

            if(config.EmitFunctionHeader)
                foreach(var line in header(src, config))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Chars.Eol));

            return dst.ToString();
        }
    }
}