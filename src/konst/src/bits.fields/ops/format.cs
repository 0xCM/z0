//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct BitFieldModels
    {
        [Op]
        public static string format(in BitFieldModel src)
            => lines(src).Intersperse(Eol).Concat();

        [Op]
        static string[] lines(in BitFieldModel src)
        {
            var dst = new string[src.FieldCount];
            for(var i=0; i<src.FieldCount; i++)
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
        public static string format<S,T>(ReadOnlySpan<S> src)
            where T : unmanaged
            where S : IBitFieldSegment<T>
        {
            var count = src.Length;
            var last = count - 1;
            var formatted = text.build();
            formatted.Append(Chars.LBracket);
            for(var i=0; i<count; i++)
            {
                ref readonly var seg = ref skip(src,i);
                formatted.Append(format<S,T>(seg));
                if(i != last)
                    formatted.Append(SegSep);
            }

            formatted.Append(Chars.RBracket);
            return formatted.ToString();
        }

        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
            where T : unmanaged
                => BitFieldModels.format<BitFieldSegment<T>,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format(in BitFieldSegment src)
            => string.Format(SegRenderPattern, src.StartPos, src.EndPos);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in BitFieldSegment<T> src)
            where T : unmanaged
                => string.Format(SegRenderPattern, src.StartPos, src.EndPos);

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        [Op]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
        {
            const char Left = Chars.LBracket;
            const char Right = Chars.RBracket;

            var dst = text.build();
            var count = src.Length;
            var last = count - 1;
            dst.Append(Left);
            for(var i=0; i<count; i++)
            {
                ref readonly var seg = ref z.skip(src,i);
                dst.Append(string.Format(SegRenderPattern, seg.StartPos, seg.EndPos));
                if(i != last)
                    dst.Append(SegSep);
            }

            dst.Append(Right);
            return dst.ToString();
        }

        static string format<S,T>(S src)
            where T : unmanaged
            where S : IBitFieldSegment<T>
                => $"[{src.Width}:{src.StartPos}..{src.EndPos}]";

        const string SegRenderPattern = "[{0},{1}]";

        const string SegSep = ", ";
    }
}