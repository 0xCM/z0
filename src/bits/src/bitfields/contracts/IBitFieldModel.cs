//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        Identifier Name {get;}

        /// <summary>
        /// The number of defined sections
        /// </summary>
        uint SegCount {get;}

        /// <summary>
        /// The accumulated section widths
        /// </summary>
        uint TotalWidth {get;}

        /// <summary>
        /// The defined segments
        /// </summary>
        Span<BitfieldSeg> Segments {get;}
    }
}