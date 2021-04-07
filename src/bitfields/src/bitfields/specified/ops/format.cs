//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static memory;

    partial struct BitfieldSpecs
    {
        [Op]
        public static void render(in BitfieldPart src, ITextBuffer dst)
            => dst.Append(src.Format());

        public static string format<T>(BitFieldPart<T> src)
            where T : unmanaged
                => TextFormat.enclose(TextFormat.adjacent(src.LastIndex, SegmentDelimiter, src.FirstIndex), SegmentFence);

        [Op]
        static string[] lines(in BitFieldModel src)
        {
            var dst = new string[src.SegmentCount];
            for(var i=0; i<src.SegmentCount; i++)
            {
                var index = i;
                var indexLabel = index.ToString().PadLeft(2, Chars.D0);
                var width = src.Width(i);
                var widthLabel = width.ToString().PadLeft(2, Chars.D0);
                var left = src.Position(i);
                var leftLabel = left.ToString().PadLeft(2, Chars.D0);
                var right = left + width - 1;
                var rightLabel = right.ToString().PadLeft(2, Chars.D0);
                dst[i] = $"{index} | {indexLabel} | {widthLabel} | [{leftLabel}..{rightLabel}]";
            }
            return dst;
        }

        [Op]
        public static string format(in BitFieldModel src)
            => lines(src).Intersperse(Eol).Concat();

        public static string format<F>(IBitFieldIndexEntry<F> entry)
            where F : unmanaged
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";

        public static string format<W>(BitFieldIndexEntry<W> src)
            where W : unmanaged, Enum
                => $"{src.FieldWidth.GetType().Name}[{src.FieldIndex}] = {src.FieldName}";

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<T>(ReadOnlySpan<BitFieldPart<T>> src)
            where T : unmanaged
        {
            var dst = text.buffer();
            dst.Append(OpenField);
            var count = src.Length;
            var last = count - 1;
            for(var i=last; i>=0; i--)
            {
                render(skip(src,i), dst);
                if(i != 0)
                    dst.Append(SegSep);
            }

            dst.Append(CloseField);
            return dst.Emit();
        }

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        [Op]
        public static string format(ReadOnlySpan<BitfieldPart> src)
        {
            var dst = text.buffer();
            dst.Append(OpenField);
            var count = src.Length;
            var last = count - 1;
            for(var i=last; i>=0; i--)
            {
                render(skip(src,i), dst);
                if(i != 0)
                    dst.Append(SegSep);
            }

            dst.Append(CloseField);
            return dst.Emit();
        }

        [Op]
        public static string format(in BitfieldPart seg)
        {
            var dst = EmptyString;
            var name = seg.Name;
            if(name.IsNonEmpty)
                dst = seg.Name;
            return dst + string.Format(SegPattern, seg.FirstIndex, seg.LastIndex);
        }

        const string SegPattern = "[{1}:{0}]";

        const string SegSep = RP.SpacedPipe;

        const char OpenField = Chars.LBracket;

        const char CloseField = Chars.RBracket;

        public const char SegmentDelimiter = Chars.Colon;

        public static Fence<char> SegmentFence
        {
            [MethodImpl(Inline)]
            get => Rules.fence(OpenField, CloseField);
        }
    }
}