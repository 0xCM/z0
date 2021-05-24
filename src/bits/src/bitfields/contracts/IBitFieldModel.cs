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
        Name Name {get;}

        /// <summary>
        /// The number of defined segments
        /// </summary>
        uint SegmentCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        uint TotalWidth {get;}

        /// <summary>
        /// The defined segments
        /// </summary>
        ReadOnlySpan<BitfieldPart> Parts {get;}
    }

    public interface IBitfieldModel<T> : IBitfieldModel
        where T : unmanaged
    {
         new ReadOnlySpan<BitFieldPart<T>> Parts {get;}

         ReadOnlySpan<BitfieldPart> IBitfieldModel.Parts
            =>  Parts.Map(s => (BitfieldPart)s);
    }
}