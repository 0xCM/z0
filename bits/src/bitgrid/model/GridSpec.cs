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
        public static bool operator ==(GridSpec a, GridSpec b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridSpec a, GridSpec b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridSpec(int rows, int cols, int segwidth, int bytes, int bits, int segs)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.SegWidth = segwidth;
            this.StorageBytes = bytes;
            this.StorageBits = bits;
            this.StorageSegs = segs;
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly int RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly int ColCount;

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public readonly int SegWidth;

        /// <summary>
        /// The the toal number of segment-aligned bits allocated for storage
        /// </summary>
        public readonly int StorageBits;

        /// <summary>
        /// The the toal number of segment-aligned bytes allocated for storage
        /// </summary>
        public readonly int StorageBytes;

        /// <summary>
        /// The the toal number of segments allocated for storage
        /// </summary>
        public readonly int StorageSegs;

        [MethodImpl(Inline)]
        public bool Equals(GridSpec rhs)
            => RowCount == rhs.RowCount && ColCount == rhs.ColCount 
            && SegWidth == rhs.SegWidth && StorageBits == rhs.StorageBits 
            && StorageBytes == rhs.StorageBytes;
        
        public override int GetHashCode()
            => HashCode.Combine(RowCount, ColCount, SegWidth, StorageBits, StorageSegs);

        public override bool Equals(object rhs)
            => rhs is GridSpec x && Equals(x);

        public string Format()
            => $"{RowCount}x{ColCount}x{SegWidth}"; 

        public override string ToString()
            => Format();
    }
}