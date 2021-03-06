//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        Name Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        uint SegCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        uint TotalSegWidth {get;}

        /// <summary>
        /// The width of the containing datatype
        /// </summary>
        uint DataWidth {get;}

        /// <summary>
        /// The defined segments
        /// </summary>
        ReadOnlySpan<BitSegment> Segments {get;}
    }
}