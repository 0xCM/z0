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
        uint SegmentCount {get;}

        /// <summary>
        /// The accumulated width of the defined segments
        /// </summary>
        uint SegmentWidth {get;}

        /// <summary>
        /// The width of the containing datatype
        /// </summary>
        uint StorageWidth {get;}

        /// <summary>
        /// The defined segments
        /// </summary>
        ReadOnlySpan<BitfieldPart> Segments {get;}
    }

    public interface IBitFieldModel<T> : IBitFieldModel
        where T : unmanaged
    {
         new ReadOnlySpan<BitFieldPart<T>> Segments {get;}

         ReadOnlySpan<BitfieldPart> IBitFieldModel.Segments
            =>  Segments.Map(s => (BitfieldPart)s);
    }
}