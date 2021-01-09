//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.BitFieldSpecs, true)]
    public readonly struct BitFieldModels
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSpec specify(params BitFieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, with an assumed underlying
        /// numeric type of byte, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="I">The indexing enum type</typeparam>
        /// <typeparam name="U">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,W>()
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => specify<I,byte,W>();

       public static BitFieldIndex<I,W> index<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
        {
            var indices = typeof(I).LiteralFields();
            var widths = typeof(W).LiteralFields();
            var count = indices.Length;
            var indexed = new BitFieldIndexEntry<I,W>[count];
            for(var i=0; i < count; i++)
                indexed[i] = entry<I,U,W>(i, indices, widths);
            return indexed;
        }

        static BitFieldIndexEntry<I,W> entry<I,U,W>(int i, FieldInfo[] indices, FieldInfo[] widths)
            where U : unmanaged
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => new BitFieldIndexEntry<I,W>(
                    Enums.literal<I,U>(NumericCast.force<int,U>(i)), indices[i].Name, (W)widths[i].GetRawConstantValue());

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, the underlying numeric type of I, T, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="E">The indexing enum type</typeparam>
        /// <typeparam name="T">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => new BitFieldSpec(segments(index<I,U,W>()));

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

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            var count = spec.FieldCount;
            var segments = spec.Segments;
            for(byte i=0; i<count; i++)
                total += skip(segments, i).Width;
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

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="id">The segment identifier</param>
        /// <param name="width">The segment width</param>
        /// <param name="seg">The inclusive left/right segment index boundaries</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSegment segment(byte width, in ConstPair<uint> boundary)
            => new BitFieldSegment(width, boundary);

        /// <summary>
        /// Describes an index-identified model segment
        /// </summary>
        /// <param name="src">The source model</param>
        /// <param name="index">The field index</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSegment segment(in BitFieldModel src, int index)
        {
            var width = src.Width(index);
            var i0 = src.Position(index);
            var i1 = (uint)(i0 + width);
            return segment((byte)width, (i0, i1));
        }

        [MethodImpl(Inline)]
        public static BitFieldSpec256<F> specify<F>(W256 w)
            where F : unmanaged, Enum
        {
            Span<F> values = Enums.literals<F>();
            var widths = values.Bytes();
            var count = root.min(widths.Length, 32);
            var data = default(Vector256<byte>);
            for(var i=0; i<count; i++)
                data = data.WithElement(i,skip(widths,i));
            return new BitFieldSpec256<F>(data);
        }

        [MethodImpl(Inline)]
        public static BitFieldSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => segment((byte)(endpos - startpos + 1), (startpos, endpos));

        public static BitFieldSegment segment<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = Enums.scalar<I,byte>(entry.FieldIndex);
            var width = Enums.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = segment(width, (start, end));
            start = (byte)(end + 1);
            return seg;
        }

        /// <summary>
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        public static BitFieldSegment[] segments<I,W>(in BitFieldIndex<I,W> index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var count = index.Length;
            var start = Konst.z8;
            var segments = new BitFieldSegment[count];
            for(var i=0; i<count; i++)
                segments[i] = segment(index[i], ref start);
            return segments;
        }

        [Op]
        public static BitFieldModel create(ReadOnlySpan<string> names, ReadOnlySpan<byte> widths)
        {
            Demands.insist(names.Length, widths.Length);
            var count = (uint)names.Length;
            var fieldWidths = span(widths);
            var posbuffer = alloc<uint>(count);
            var positions = span(posbuffer);
            var sBuffer = alloc<BitFieldSegment>(count);
            var segments = span(sBuffer);
            uint totalWidth = 0;
            for(var i=0u; i<count; i++)
            {
                ref readonly var w = ref skip(widths,i);
                ref readonly var n = ref skip(names,i);
                seek(positions,i) = totalWidth;
                seek(segments,i) = new BitFieldSegment(w, (totalWidth, totalWidth + w));
                totalWidth += skip(fieldWidths, i);
            }
            return new BitFieldModel(count, totalWidth, sBuffer);
        }

        [MethodImpl(Inline)]
        static string format<S,T>(S src)
            where T : unmanaged
            where S : IBitFieldSegment<T>
                => $"[{src.Width}:{src.StartPos}..{src.EndPos}]";

        const string SegRenderPattern = "[{0},{1}]";

        const string SegSep = ", ";
    }
}