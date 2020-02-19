//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public static class BitField
    {
        public static FieldSegment[] segments<E>(FieldIndexEntry<E>[] indices)
            where E : unmanaged, Enum
        {            
            var count = indices.Length;
            var segments = new FieldSegment[count];
            
            var start = byte.MinValue;
            for(var i=0; i<count; i++)
            {
                var entry = indices[i];
                var width = evalue<E,byte>(entry.FieldValue);
                var endpos = (byte)(start + width - 1);
                segments[i] = FieldSegments.define(entry.FieldName, (byte)i, start, endpos, width);
                start = (byte)(endpos + 1);
            }
            return segments;
        }

        /// <summary>
        /// Defines a bitfield predicated on an enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<E>()
            where E : unmanaged, Enum
                => new BitFieldSpec(segments(FieldIndex.Entries<E>()));

        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify(params FieldSegment[] segments)
            => new BitFieldSpec(segments);

        [MethodImpl(Inline)]
        public static T read<T>(in FieldSegment segment, T src)
            where T : unmanaged
                => gbits.bitslice(src, segment.StartPos, segment.Width);

        [MethodImpl(Inline)]
        public static T read<T>(in FieldSegment segment, T src, bool offset)
            where T : unmanaged
                => offset ? gmath.sll(read(segment, src), segment.StartPos)  : read(segment,src);

        [MethodImpl(Inline)]
        public static void read<T>(in BitFieldSpec spec, T src, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<spec.FieldCount; i++)
                seek(dst,i) = read(skip(spec.Segments,i), src);
        }

        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline)]
        public static byte width(in BitFieldSpec spec)
        {
            var total = 0;
            for(byte i=0; i< spec.Segments.Length; i++)
                total += spec.Segment(i).Width;
            return (byte)total;            
        }

        public static string format(in BitFieldSpec spec)
            => FieldSegments.format(spec.Segments);
    }
}