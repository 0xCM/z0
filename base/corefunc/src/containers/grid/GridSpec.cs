//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct GridSpec
    {

        [MethodImpl(Inline)]
        public GridSpec(uint RowCount, uint ColCount, uint SegWidth)
        {
            this.RowCount = RowCount;
            this.ColCount = ColCount;
            this.SegWidth = SegWidth;
            this.Volume = RowCount * ColCount;
            this.Storage = Volume + (Volume % SegWidth != 0 ? SegWidth : 0);
            this.Segments = Storage / SegWidth;
        }
        
        
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly uint RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly uint ColCount;

        /// <summary>
        /// The number of individuals covered by the grid
        /// </summary>
        public readonly uint Volume;

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public readonly BitSize SegWidth;

        /// <summary>
        /// The the toal number of segment-aligned bits allocated for storage
        /// </summary>
        public readonly BitSize Storage;

        /// <summary>
        /// The the toal number of segments allocated for storage
        /// </summary>
        public readonly uint Segments;

        public string Format()
            => $"{RowCount}x{ColCount}x{SegWidth}"; 

        public override string ToString()
            => Format();
    }
}