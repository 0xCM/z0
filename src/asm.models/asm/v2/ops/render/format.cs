//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AsmRender
    {
        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W16,uint,ushort> src)
            => src.Format();

        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W32,uint,uint> src)
            => src.Format();

        public static string format(in MemoryOffset moffs)
            => text.concat(((ushort)moffs.Offset).FormatAsmHex(), Chars.Space, moffs.Absolute);

        public static void format(in MemoryOffsets offsets, Span<string> dst)
        {
            var empty = MemoryOffset.Empty;
            for(var k=0u; k<offsets.Count; k++)
            {
                ref readonly var prior = ref (k == 0 ? ref empty : ref offsets[k-1]);
                ref readonly var current = ref offsets[k];
                seek(dst,k) = format(prior, current);
            }
        }

        public static Span<string> format(in MemoryOffsets offsets)
        {
            var empty = MemoryOffset.Empty;
            var dst = sys.alloc<string>(offsets.Count);
            format(offsets,dst);
            return dst;
        }

        public static string format(in MemoryOffset prior, in MemoryOffset moffs)
        {
            const char Sep = Chars.Space;
            const NumericWidth OffsetWidth = NumericWidth.W16;
            const string BaseIndicator = "@base";
            const string PriorIndicator = "@prior";
            const char Selector = Chars.Plus;

            var offset = moffs.OffsetAddress;
            var offsetFmt = offset.Format(OffsetWidth);
            var moffsBase = text.concat(BaseIndicator, Selector, offsetFmt);
            var priorFmt = text.concat(PriorIndicator, Selector, prior.Absolute.Format(OffsetWidth));

            if(prior.IsEmpty)
                return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, priorFmt);

            var delta = moffs.Absolute - prior.Absolute;
            var deltaFmt = delta.Format(OffsetWidth);
            var moffsPrior = text.concat(PriorIndicator, Selector, deltaFmt);

            return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, moffsPrior);
        }

        public static string[] format<E>(MemSlotView<E> src)
            where E : unmanaged, Enum
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        public static void format<E>(MemSlotView<E> src, Span<string> dst)
            where E : unmanaged, Enum
        {
            var count = src.Length;
            ref readonly var lead = ref src.Lookup(default(E));
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(lead,i).Format();
        }

        [MethodImpl(Inline), Op]
        public static string format(AsmFxCode src, byte[] encoded, string sep)
            =>  text.format("{0,-30}{1}{2,-40}{3}{4,-3}{5}{6}",
                src.Expression, sep,
                src.OpCode, sep,
                encoded.Length, sep,
                encoded.FormatHexBytes(Space,true,false)
                );

        [Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src, in AsmFormatSpec config)
        {
            var description = text.build();
            var absolute = @base + (MemoryAddress)src.Offset;
            description.Append(text.concat(label(src.Offset), src.Formatted.PadRight(config.InstructionPad, Space)));
            description.Append(comment(format(src.Spec, src.Encoded, config.FieldDelimiter)));
            //description.Append(text.concat(config.FieldDelimiter, src.Encoded.Length, config.FieldDelimiter, src.Encoded.FormatHexBytes(Space, true, false)));
            return description.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(in MemoryAddress @base, in AsmFxSummary src)
            => format(@base, src, AsmFormatSpec.Default);

        [Op]
        public static string format(in AsmRoutines src, in AsmFormatSpec config)
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
        public static string format(in AsmRoutine src, in AsmFormatSpec config)
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