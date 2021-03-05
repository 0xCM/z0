//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct BitFieldModels
    {
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
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
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

        [MethodImpl(Inline), Op]
        public static void render(in BitFieldSegment src, ITextBuffer dst)
            => dst.Append(format(src));

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        [Op]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
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
        public static string format(in BitFieldSegment seg)
        {
            var dst = EmptyString;
            var name = seg.Name;
            if(name.IsNonEmpty)
                dst = seg.Name;
            return dst + format(seg.Section);
        }

        [Op]
        public static string format(in BitSection src)
            => string.Format(SegPattern, src.StartPos, src.EndPos);

        const string SegPattern = "[{1}:{0}]";

        const string SegSep = RP.SpacedPipe;

        const char OpenField = Chars.LBracket;

        const char CloseField = Chars.RBracket;
    }
}