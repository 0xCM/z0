//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct BitfieldSegSpec<T>
        where T : unmanaged
    {
        /// <summary>
        /// The name of the containing section
        /// </summary>
        public StringAddress SectionName {get;}

        /// <summary>
        /// The name of the segment section
        /// </summary>
        public StringAddress SegmentName {get;}

        /// <summary>
        /// The index, relative to the containing section, of the first bit in the segment
        /// </summary>
        public T FirstIndex {get;}

        /// <summary>
        /// The index, relative to the containing section, of the last bit in the segment
        /// </summary>
        public T LastIndex {get;}

        [MethodImpl(Inline)]
        public BitfieldSegSpec(StringAddress section, StringAddress segment, T min, T max)
        {
            SectionName = section;
            SegmentName = segment;
            FirstIndex = min;
            LastIndex = max;
        }
    }
}