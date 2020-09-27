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

    public readonly struct BitFieldFormatter
    {
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
            => format<BitFieldSegment,byte>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(in BitFieldSegment<T> src)
            where T : unmanaged
                => $"{src.Name}({src.Width}:{src.StartPos}..{src.EndPos})";

        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
            where T : unmanaged
                => format<BitFieldSegment<T>,T>(src);

        [MethodImpl(Inline)]
        public static string format<F>(F entry)
            where F : unmanaged, IBitFieldIndexEntry<F>
                => $"{entry.FieldWidth.GetType().Name}[{entry.FieldIndex}] = {entry.FieldName}";

        public static string format(in BitFieldModel src)
            => lines(src).Intersperse("\r\n").Concat();

        public static string[] lines(in BitFieldModel src)
        {
            var dst = new string[src.FieldCount];
            for(var i=0; i<src.FieldCount; i++)
            {
                var index = i;
                var indexLabel = index.ToString().PadLeft(2, Chars.D0);
                var name = src.Name(i);
                var width = src.Width(i);
                var widthLabel = width.ToString().PadLeft(2, Chars.D0);
                var left = src.Position(i);
                var leftLabel = left.ToString().PadLeft(2, Chars.D0);
                var right = left + width - 1;
                var rightLabel = right.ToString().PadLeft(2, Chars.D0);
                dst[i] = $"{src.BitFieldName} | {name} | {indexLabel} | {widthLabel} | [{leftLabel}..{rightLabel}]";
            }
            return dst;
        }

        public static string format<W>(in BitFieldIndexEntry<W> src)
            where W : unmanaged, Enum
                => $"{src.FieldWidth.GetType().Name}[{src.FieldIndex}] = {src.FieldName}";

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="V">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<V,T>(V value)
            where V : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = Enums.scalar<V,T>(value);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormatter.limited(limit);
            var name = typeof(V).Name;
            var bits = formatter.Format(data,config);
            return text.concat(name, Chars.Colon, bits);
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
            var sep =$"{Chars.Comma}{Chars.Space}";
            var formatted = new StringBuilder();
            formatted.Append(Chars.LBracket);
            for(var i=0; i< src.Length; i++)
            {
                formatted.Append(Format(src[(byte)i]));
                if(i != src.Length - 1)
                    formatted.Append(sep);
            }

            formatted.Append(Chars.RBracket);
            return formatted.ToString();
        }

        static string Format<T>(IBitFieldSegment<T> src)
            where T : unmanaged
                => $"{src.Name}({src.Width}:{src.StartPos}..{src.EndPos})";
    }
}