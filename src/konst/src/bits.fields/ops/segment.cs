//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct BitFieldModels
    {
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
        public static BitFieldSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => segment((byte)(endpos - startpos + 1), (startpos, endpos));

        public static BitFieldSegment segment<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = EnumValue.scalar<I,byte>(entry.FieldIndex);
            var width = EnumValue.scalar<W,byte>(entry.FieldWidth);
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
    }
}