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
    using static TextRules;
    using static memory;

    partial struct BitFields
    {
        public static string format(ReadOnlySpan<byte> bits, ReadOnlySpan<byte> parts)
        {
            var count = parts.Length;
            if(count == 0)
                return EmptyString;

            var dst = text.buffer();
            Span<char> bitstring = stackalloc char[bits.Length];
            BitFormatter.format(bits, bitstring);
            var current = z8;
            dst.Append(Chars.LBracket);
            for(var i=0; i<count; i++)
            {
                ref readonly var pos = ref skip(parts,i);
                var segment = slice(bitstring, current, pos);
                dst.Append(segment);
                dst.Append(Chars.Space);
                current += (byte)segment.Length;
            }
            dst.Append(slice(bitstring,current));
            dst.Append(Chars.RBracket);

            return dst.Emit();
        }

        public static string format<T>(T src, ReadOnlySpan<byte> parts)
            where T : unmanaged
                => format(bytes(src), parts);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
                => format<E,T>(src, typeof(E).Name, zpad);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, string name, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            var data = EnumValue.scalar<E,T>(src);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormatter.limited(limit,zpad);
            return text.concat(name, Chars.Colon, formatter.Format(data,config));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, Base10 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = EnumValue.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Numeric.format(data, @base));
        }

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, Base16 @base, string name)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = EnumValue.scalar<E,T>(src);
            return text.concat(name, Chars.Colon, Hex.formatter<T>().FormatItem(data));
        }

       public static string format<T>(BitSegment<T> src)
            where T : unmanaged
                => Format.enclose(Format.adjacent(src.EndPos, SegmentDelimiter, src.StartPos), SegmentFence);


        [Op]
        static string[] lines(in BitFieldModel src)
        {
            var dst = new string[src.SegCount];
            for(var i=0; i<src.SegCount; i++)
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
        public static string format<T>(ReadOnlySpan<BitSegment<T>> src)
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
        public static void render(in BitSegment src, ITextBuffer dst)
            => dst.Append(src.Format());

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        [Op]
        public static string format(ReadOnlySpan<BitSegment> src)
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
        public static string format(in BitSegment seg)
        {
            var dst = EmptyString;
            var name = seg.Name;
            if(name.IsNonEmpty)
                dst = seg.Name;
            return dst + string.Format(SegPattern, seg.StartPos, seg.EndPos);
        }

        const string SegPattern = "[{1}:{0}]";

        const string SegSep = RP.SpacedPipe;

        const char OpenField = Chars.LBracket;

        const char CloseField = Chars.RBracket;
    }
}