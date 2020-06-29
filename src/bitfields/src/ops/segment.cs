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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly BitFieldSegment segment<T>(in BitField<T> field, int index)
            where T : unmanaged            
                => ref field.Segment(index);        

        [MethodImpl(Inline)]
        public static BitFieldSegment segment<I,W>(BitField64<I,W> src, I index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => Root.skip(src.Spec.Segments, Enums.scalar<I,byte>(index));

        [MethodImpl(Inline)]
        public static BitFieldSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => segment(id.ToString(), startpos, endpos, (byte)(endpos - startpos + 1));

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="i0">The position of the first bit in the segment</param>
        /// <param name="i1">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static BitFieldSegment<T> segment<T>(string name, T i0, T i1, T width)
            where T : unmanaged
                => new BitFieldSegment<T>(name, i0, i1, width);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSegment segment(string name, byte startpos, byte endpos, byte width)
            => new BitFieldSegment(name,startpos, endpos, width);

        /// <summary>
        /// Describes an index-identifed model segment
        /// </summary>
        /// <param name="src">The source model</param>
        /// <param name="index">The field index</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSegment segment(in BitFieldModel src, byte index)
        {
            var width = src.Width(index);
            var i0 = src.Position(index);
            var i1 = (byte)(i0 + width);
            return segment(src.Name(index), i0, i1, width);
        }

        internal static BitFieldSegment segment<I,W>(in BitFieldIndexEntry<I,W> entry, ref byte start)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var i = Enums.scalar<I,byte>(entry.FieldIndex);
            var width = Enums.scalar<W,byte>(entry.FieldWidth);
            var end = (byte)(start + width - 1);
            var seg = BitFields.segment(entry.FieldName, start, end, width);
            start = (byte)(end + 1);
            return seg;
        }
    }
}