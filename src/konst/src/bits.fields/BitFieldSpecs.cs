//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.BitFieldSpecs, true)]
    public readonly struct BitFieldSpecs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format(in BitFieldSegment src)
            => string.Format(SegRenderPattern, src.StartPos, src.EndPos);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
            const string Sep = ", ";
            const char Left = Chars.LBracket;
            const char Right = Chars.RBracket;

            var formatted = text.build();
            var count = src.Length;
            var last = count - 1;
            formatted.Append(Left);
            for(var i=0; i<count; i++)
            {
                ref readonly var seg = ref z.skip(src,i);
                formatted.Append(string.Format(SegRenderPattern, seg.StartPos, seg.EndPos));
                if(i != last)
                    formatted.Append(Sep);
            }

            formatted.Append(Right);
            return formatted.ToString();
        }

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            var count = spec.FieldCount;
            var segments = spec.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments,i).Width;
            return total;
        }

        [Op]
        public static string format(in BitFieldModel src)
            => lines(src).Intersperse(Eol).Concat();

        [Op]
        public static string[] lines(in BitFieldModel src)
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
            var sep =$"{Chars.Comma}{Chars.Space}";
            var formatted = text.build();
            formatted.Append(Chars.LBracket);
            for(var i=0; i<count; i++)
            {
                formatted.Append(Format(src[(byte)i]));
                if(i != last)
                    formatted.Append(sep);
            }

            formatted.Append(Chars.RBracket);
            return formatted.ToString();
        }

        [Op, Closures(UnsignedInts)]
        static string Format<T>(IBitFieldSegment<T> src)
            where T : unmanaged
                => $"[{src.Width}:{src.StartPos}..{src.EndPos}]";

        const string SegRenderPattern = "[{1},{2}]";
    }
}