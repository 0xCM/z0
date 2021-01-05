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
    using static AsmDocParts;

    [ApiHost]
    public readonly struct AsmRender
    {
        [Op]
        public static string format(in LineLabel src)
            => src.Width switch{
                DataWidth.W8 => ScalarCast.uint8(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W16 => ScalarCast.uint16(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W32 => ScalarCast.uint32(src.Offset).FormatAsmHex() + CharText.Space,
                DataWidth.W64 => src.Offset.FormatAsmHex() + CharText.Space,
                _ => EmptyString
            };

        [Op]
        public static byte lines(in BlockHeader src, Span<string> dst)
        {
            var i = z8;
            memory.seek(dst, i++) = src.Separator;
            memory.seek(dst, i++) = AsmRender.comment($"{src.Signature}:: {src.Uri}");
            memory.seek(dst, i++) = ByteSpans.property(src.CodeBlock, src.Uri.OpId);
            memory.seek(dst, i++) = AsmRender.comment(text.concat(nameof(src.CodeBlock.BaseAddress), text.spaced(Chars.Eq), src.CodeBlock.BaseAddress));
            memory.seek(dst, i++) = AsmRender.comment(text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString()));
            return i;
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<string> header(AsmRoutine src)
        {
            var dst = span<string>(8);
            var count = lines(AsmDocs.header(src), dst);
            return slice(dst, 0, count);
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
            => text.format("{0,-32}{1}{2,-32}{3}{4,-3}{5}{6}", src.Sig, sep, src.OpCode, sep, encoded.Length, sep, encoded.FormatHexBytes(Space,true,false));

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
            var label = AsmDocs.label(w16, src.Offset);
            var absolute = @base + src.Offset;
            dst.Append(text.concat(format(label), src.Formatted.PadRight(config.InstructionPad, Space)));
            dst.Append(comment(format(src.Spec, src.Encoded, config.FieldDelimiter)));
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