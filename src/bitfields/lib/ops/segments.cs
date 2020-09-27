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
        /// Creates the field segment array as determined by a field index
        /// </summary>
        /// <param name="index">The source index</param>
        /// <typeparam name="W">The enum type with width-defining literals</typeparam>
        internal static BitFieldSegment[] segments<I,W>(in BitFieldIndex<I,W> index)
            where I : unmanaged, Enum
            where W : unmanaged, Enum
        {            
            var count = index.Length;
            var start = Konst.z8;
            var segments = new BitFieldSegment[count];            
            for(var i=0; i<count; i++)
                segments[i] = BitFields.segment(index[i], ref start);
            return segments;
        }
    }
}