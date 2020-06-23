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
        public static GridStats Define(GridMap src)
            => new GridStats(
            
                RowCount : src.RowCount,
                ColCount : src.ColCount,
                SegWidth : src.SegWidth,
                StorageSegs : src.SegCount,
                StorageBits : src.StorageBits,
                StorageBytes : src.StorageBytes,
                PointCount : src.PointCount,
                Vec128Count : src.Vec128Count,
                Vec128Remainder : src.Vec128Remainder,
                Vec256Count : src.Vec256Count,
                Vec256Remainder : src.Vec256Remainder
            );
        
        GridStats()
        {

        }

        public GridStats(ushort RowCount, ushort ColCount,  ushort SegWidth, int PointCount, 
            int StorageSegs, int StorageBits, int StorageBytes, int Vec128Count, int Vec128Remainder, int Vec256Count, int Vec256Remainder)
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
        public int PointCount {get;}

        /// <summary>
        /// The number of segment-aligned segments required for storage
        /// </summary>
        public int SorageSegs {get;}

        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        public int StorageBits {get;}

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        public int StorageBytes {get;}
            
        /// <summary>
        /// The number of whole 128-bit vectors required for storage
        /// </summary>
        public int Vec128Count {get;}

        /// <summary>
        /// The number bytes that do not fit into a whole number of 128-bit vectors
        /// </summary>
        public int Vec128Remainder  {get;}
        
        /// <summary>
        /// The number of whole 256-bit vectors required for storage
        /// </summary>
        public int Vec256Count {get;}
            
        /// <summary>
        /// The number bytes that do not fit into a whole number of 256-bit vectors
        /// </summary>
        public int Vec256Remainder {get;}            
    }
}