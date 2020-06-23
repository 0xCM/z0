//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 

    /// <summary>
    /// Characterizes the memory layout of a BitMatrix
    /// </summary>
    public readonly struct GridSpec<T>
        where T : unmanaged
    {
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly T RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly T ColCount;

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public readonly T SegWidth;

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
        public static GridSpec<T> Define(T rows, T cols, T segwidth, int bytes, int bits, int segs)    
            => new GridSpec<T>(rows, cols, segwidth, bytes, bits, segs);

        [MethodImpl(Inline)]
        public static bool operator ==(GridSpec<T> a, GridSpec<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridSpec<T> a, GridSpec<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridSpec(T rows, T cols, T segwidth, int bytes, int bits, int segs)
        {
            RowCount = rows;
            ColCount = cols;
            SegWidth = segwidth;
            StorageBytes = bytes;
            StorageBits = bits;
            StorageSegs = segs;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridSpec<T> rhs)
            => gmath.eq(RowCount,rhs.RowCount) 
            && gmath.eq(ColCount,rhs.ColCount)
            && gmath.eq(SegWidth,rhs.SegWidth) 
            && gmath.eq(StorageBits, rhs.StorageBits) 
            && gmath.eq(StorageBytes, rhs.StorageBytes);
        
        public override int GetHashCode()
            => HashCode.Combine(RowCount, ColCount, SegWidth, StorageBits, StorageSegs);

        public override bool Equals(object rhs)
            => rhs is GridSpec<T> x && Equals(x);

        public string Format()
            => $"{RowCount}x{ColCount}x{SegWidth}"; 

        public override string ToString()
            => Format();
    }
}