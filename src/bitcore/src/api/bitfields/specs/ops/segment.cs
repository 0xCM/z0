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
        public static BitSegment<T> segment<T>(Identifier name, T start, T end)
            where T : unmanaged
                => new BitSegment<T>(name, start, end);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="id">The segment identifier</param>
        /// <param name="width">The segment width</param>
        /// <param name="seg">The inclusive left/right segment index boundaries</param>
        [MethodImpl(Inline), Op]
        public static BitSegment segment(Identifier name, uint start, uint end)
            => new BitSegment(name, start, end);

        [MethodImpl(Inline)]
        public static BitSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => segment((Identifier)id.ToString(), startpos, (uint)endpos);

        public static BitSegment segment<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = EnumValue.scalar<I,byte>(entry.FieldIndex);
            var width = EnumValue.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = segment((Identifier)entry.FieldName, start, (uint)end);
            start = (byte)(end + 1);
            return seg;
        }

        /// <summary>
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        public static BitSegment[] segments<I,W>(in BitFieldIndex<I,W> index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var count = index.Length;
            var start = Konst.z8;
            var segments = new BitSegment[count];
            for(var i=0; i<count; i++)
                segments[i] = segment(index[i], ref start);
            return segments;
        }
    }
}