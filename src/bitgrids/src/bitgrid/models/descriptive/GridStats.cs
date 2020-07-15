//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    
    public class GridStats
    {        
        [MethodImpl(Inline)]
        public static GridStats Define(in GridMetrics src)
            => new GridStats(
            
                RowCount : src.RowCount,
                ColCount : src.ColCount,
                SegWidth : src.CellWidth,
                StorageSegs : src.CellCount,
                StorageBits : src.StoreWidth,
                StorageBytes : src.StoreSize,
                PointCount : GridMetrics.points(src),
                Vec128Count : GridMetrics.coverage(src,W128.W),
                Vec128Remainder : GridMetrics.remainder(src,W128.W),
                Vec256Count : GridMetrics.coverage(src,W256.W),
                Vec256Remainder : GridMetrics.remainder(src,W256.W)
            );
        
        GridStats()
        {

        }

        public GridStats(ushort RowCount, ushort ColCount,  ushort SegWidth, uint PointCount, 
            uint StorageSegs, uint StorageBits, uint StorageBytes, uint Vec128Count, uint Vec128Remainder, uint Vec256Count, uint Vec256Remainder)
        {
            this.Name = $"{RowCount}x{ColCount}";
            this.RowCount = RowCount;
            this.ColCount = ColCount;
            this.SegWidth = SegWidth;
            this.SorageSegs = StorageSegs;
            this.StorageBits = StorageBits;
            this.StorageBytes = StorageBytes;
            this.PointCount = PointCount;
            this.Vec128Count = Vec128Count;
            this.Vec128Remainder = Vec128Remainder;
            this.Vec256Count = Vec256Count;
            this.Vec256Remainder = Vec256Remainder;
        }
        
        public asci16 Name {get;}

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public ushort RowCount {get;}
        
        /// <summary>
        /// The number of grid columns
        /// </summary>
        public ushort ColCount {get;}

        /// <summary>
        /// The number of bits in a storage segment
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The number of points covered by the grid
        /// </summary>
        public uint PointCount {get;}

        /// <summary>
        /// The number of segment-aligned segments required for storage
        /// </summary>
        public uint SorageSegs {get;}

        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        public uint StorageBits {get;}

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        public uint StorageBytes {get;}
            
        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        public uint Vec128Count {get;}

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        public uint Vec128Remainder  {get;}
        
        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        public uint Vec256Count {get;}
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        public uint Vec256Remainder {get;}            
    }
}