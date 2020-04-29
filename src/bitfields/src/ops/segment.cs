//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline), Op]
        public static FieldSegment segment(string name, byte index, byte startpos, byte endpos, byte width)
            => new FieldSegment(name,index, startpos, endpos, width);

        [MethodImpl(Inline)]
        public static FieldSegment segment<E>(E id, byte startpos, byte endpos)
            where E : unmanaged, Enum
                => BitFields.segment(id.ToString(), Enums.numeric<E,byte>(id), startpos, endpos, (byte)(endpos - startpos + 1));
    }
}