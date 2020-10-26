//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitFields
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

        internal static BitFieldSegment segment<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = Enums.scalar<I,byte>(entry.FieldIndex);
            var width = Enums.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = BitFields.segment(width, (start, end));
            start = (byte)(end + 1);
            return seg;
        }
    }
}