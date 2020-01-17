//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly ushort RowCount;
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public readonly ushort SegWidth;

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


        /// <summary>
        /// Defines a grid specification predicated on specified row count, col count and bit width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridSpec Define(ushort rows, ushort cols, ushort segwidth)    
            => new GridSpec(rows: rows, cols : cols, segwidth : segwidth);

        /// <summary>
        /// Defines a grid specification predicated on specified row count, col count and bit width of a parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(Inline)]
        public static GridSpec Define<T>(ushort rows, ushort cols) 
            where T : unmanaged   
                => Define(rows, cols, (ushort)bitsize<T>());
         
        [MethodImpl(Inline)]
        public static GridSpec Define<M,N,T>(M m = default, N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => Define<T>(natval<M>(), natval<N>());

        [MethodImpl(Inline)]
        public static bool operator ==(GridSpec a, GridSpec b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridSpec a, GridSpec b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridSpec(ushort rows, ushort cols, ushort segwidth)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.SegWidth = segwidth;
            this.StorageBytes = BitCalcs.tablesize((int)rows, (int)cols);
            this.StorageBits = StorageBytes*8;
            this.StorageSegs = BitCalcs.tablecells((int)rows,(int)cols,(int)segwidth);
        }

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