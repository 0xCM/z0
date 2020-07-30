//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    /// <summary>
    /// Represents the shape of an array type.
    /// </summary>
    public readonly struct ArrayShape
    {
        /// <summary>
        /// Gets the number of dimensions in the array.
        /// </summary>
        public int Rank { get; }

        /// <summary>
        /// Gets the sizes of each dimension. Length may be smaller than rank, in which case the trailing dimensions have unspecified sizes.
        /// </summary>
        public int[] Sizes { get; }

        /// <summary>
        /// Gets the lower-bounds of each dimension. Length may be smaller than rank, in which case the trailing dimensions have unspecified lower bounds.
        /// </summary>
        public int[] LowerBounds { get; }

        public ArrayShape(int rank, int[] sizes, int[] lowerBounds)
        {
            Rank = rank;
            Sizes = sizes;
            LowerBounds = lowerBounds;
        }
    }        
}