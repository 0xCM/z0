//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmRender
    {
        const char Space = Chars.Space;

        const string PageBreak = text.PageBreak;

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<string> header(AsmRoutine src, in AsmFormatConfig config)
        {
            var lines = new List<string>();
            lines.Add(comment($"{src.OpSig}, {src.Uri}"));

            if(config.EmitFunctionHeaderEncoding)
                lines.Add(ByteSpans.property(src.Code.Code, src.Uri.OpId));
            else
                lines.Add(comment(src.Code.Uri.OpId));

            if(config.EmitBaseAddress)
                lines.Add(comment(text.concat("Base", text.spaced(Chars.Eq), src.Code.BaseAddress)));

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

        [Op]
        public static uint format(in AsmFxList src, in AsmFormatConfig config, Span<string> dst)
        {
            var count = src.Count;
            if(count == 0)
                return 0;

            var summaries =  asm.summarize(src);
            var @base = src[0].IP;
            for(var i=0u; i<(uint)count; i++)
                seek(dst,i) = format(@base, skip(summaries,i), config);

            return count;
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
            var dst = text.build();
            format(@base, src, config, dst);
            return dst.ToString();
        }

        [Op]
        public static void format(in MemoryAddress @base, in AsmFxSummary src, in AsmFormatConfig config, StringBuilder dst)
        {
            var absolute = @base + src.Offset;
            var ll = label((ushort)src.Offset);
            dst.Append(text.concat(ll, src.Formatted.PadRight(config.InstructionPad, Space)));
            dst.Append(comment(format(src.Spec, src.Encoded, config.FieldDelimiter)));
        }

        [MethodImpl(Inline), Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src)
            => format(@base, src, AsmFormatConfig.Default);

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

                    if(config.EmitSectionDelimiter)
                        dst.AppendLine(PageBreak);
                    else
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
            if(config.EmitSectionDelimiter)
                dst.AppendLine(config.SectionDelimiter);

            if(config.EmitFunctionHeader)
                foreach(var line in header(src, config))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }

        [Op]
        public static void format(in AsmRoutine src, in AsmFormatConfig config, ITextBuffer dst)
        {
            if(config.EmitSectionDelimiter)
                dst.AppendLine(config.SectionDelimiter);

            if(config.EmitFunctionHeader)
                foreach(var line in header(src, config))
                    dst.AppendLine(line);

            dst.AppendLine(lines(src, config).Concat(Eol));
        }
    }
}