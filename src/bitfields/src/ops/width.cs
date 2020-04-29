//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        /// <summary>
        /// Computes the aggregate width of the segments that comprise the bitfield
        /// </summary>
        /// <param name="spec">The bitfield spec</param>
        [MethodImpl(Inline), Op]
        public static uint width(in BitFieldSpec spec)
        {
            var total = 0u;
            for(byte i=0; i< spec.Segments.Length; i++)
                total += spec.Segment(i).Width;
            return total;            
        }
    }
}