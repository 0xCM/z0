//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial struct BitfieldSpecs
    {
        /// <summary>
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        public static Index<BitfieldPart> parts<I,W>(in BitFieldIndex<I,W> index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {
            var count = index.Length;
            var start = z8;
            var segments = new BitfieldPart[count];
            for(var i=0; i<count; i++)
                segments[i] = part(index[i], ref start);
            return segments;
        }
    }
}